using NLog;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Xml.Serialization;
using static System.Net.Mime.MediaTypeNames;

namespace WinFormsApp1
{
    public class Zoo
    {

        public LocalizationManager lmanager;
        public int money = 1000000;
        public int aviary_id = 0;
        public int food_id = 0;
        public int animal_id = 0;
        public void init_manager()
        {
            Encoding.RegisterProvider(CodePagesEncodingProvider.Instance);
            string text = File.ReadAllText(LocalizationManager.path, LocalizationManager.encoding);
            lmanager = JsonSerializer.Deserialize<LocalizationManager>(text);
        }
        public Zoo() 
        {
            init_manager();
        }
        public void init_managers()
        {
            init_manager();
            for (int i = 0; i < foods.Length; i++)
            {
                foods[i].init_lmanager();
            }
            for (int i = 0; i < aviaries.Length; i++)
            {
                aviaries[i].init_lmanager();
            }
            for (int i = 0; i < aviaries.Length; i++)
            {
                for (int j = 0; j < aviaries[i].animals.Length; j++)
                {
                    aviaries[i].animals[j].init_lmanager();
                }
            }

        }
        public Aviary[] aviaries = new Aviary[] { };
        public Food[] foods = new Food[] { };

        private string serialization_path = @".\data\food.xml";
        public int get_money()
        {
            return money;
        }
        public void set_money(int money)
        {
            this.money = money;
        }

        public void let_visitors_in(Label place, ListBox listbox) 
        {
            Animal dead_animal;
            Herbivore play_animal;
            int start_money = money;
            place.Text = "";
            for(int i = 0; i < aviaries.Length; i++)
            {
                for(int j = 0; j < aviaries[i].animals.Length; j++)
                {
                    if (aviaries[i].animals[j] is Herbivore)
                    {
                        play_animal = (Herbivore)aviaries[i].animals[j];
                        money += play_animal.play(place);
                    }
                    money += aviaries[i].animals[j].get_income();
                }
                for (int j = 0; j < aviaries[i].animals.Length; j++)
                {
                    aviaries[i].animals[j].satiety -= aviaries[i].animals[j].get_needed_food();
                    if (aviaries[i].animals[j].satiety <= 0)
                    {
                        dead_animal = aviaries[i].animals[j];
                        listbox.Items.RemoveAt(listbox.Items.IndexOf(aviaries[i].animals[j].id));
                        aviaries[i].animals = aviaries[i].animals.Where(a => a.id != aviaries[i].animals[j].id).ToArray();
                        aviaries[i].occupied_area -= dead_animal.get_needed_area();
                        dead_animal.death(place);
                    }
                }
            }
            place.Text += lmanager.PassedDayPayment + (money - start_money).ToString();
            var logger = NLog.LogManager.GetCurrentClassLogger();
            logger.Info(lmanager.PassedDayPayment + (money - start_money).ToString());
        }
        public void get_status(Label place) {

            place.Text = "";
            place.Text += lmanager.Resources + money.ToString() + '\n' + '\n';

            for (int i = 0; i < aviaries.Length; i++)
            {
                aviaries[i].get_info(place);
            }
            place.Text += '\n';
            for (int i = 0; i < foods.Length; i++)
            {
                foods[i].get_info(place);
            }
        }
        public void buy_aviary(int area, Label place, ListBox listbox) {
            place.Text = "";
            var logger = NLog.LogManager.GetCurrentClassLogger();
            if (area < 0)
            {
                place.Text = lmanager.INVALID_DATA;
                logger.Info(place.Text);
                return;
            }
            if (area * 1.4 > money)
            {
                place.Text = lmanager.NoMoneyWarning;
                logger.Info(place.Text);
                return;
            }

            money -= (int)(area * 1.4);
            aviaries = aviaries.Append(new Aviary(area, aviary_id)).ToArray();
            aviary_id += 1;
            place.Text = lmanager.AviaryBought + aviaries[aviaries.Length - 1].area.ToString() + '\n';
            logger.Info(place.Text);
            listbox.Items.Add(aviaries.Last().id);
        }
        public void buy_food(int payment, int id, ListBox listbox, Label place)
        {
            place.Text = "";
            id -= 1;
            int initial_payment = payment;
            if(payment > money)
            {
                place.Text = lmanager.NoMoneyWarning;
                var logger = NLog.LogManager.GetCurrentClassLogger();
                logger.Info(place.Text);
                return;
            }
            money -= payment;
            Func<Food>[] factories = new Func<Food>[2] { () => new Meat(), () => new Grass() };

            Food food = factories[id]();
            while (payment - food.get_price() >= 0)
            {
                payment -= food.get_price();
                food.id = food_id;
                foods = foods.Append(food).ToArray();
                listbox.Items.Add(food_id);
                food_id += 1;
                food = factories[id]();
            }

            money += payment;
            place.Text += lmanager.Bought + food.get_type() + lmanager.OnCost + (initial_payment - payment).ToString();
            
        }
        public void feed(ListBox animal_ids, ListBox food_ids, Label place)
        {
            if(animal_ids.SelectedIndex == -1 || food_ids.SelectedIndex == -1)
            {
                place.Text = lmanager.INVALID_DATA;
                var logger = NLog.LogManager.GetCurrentClassLogger();
                logger.Info(place.Text);
                return;
            }
            place.Text = "";
            int needed_animal_id = (int)animal_ids.SelectedItem;
            int needed_food_id = (int)food_ids.SelectedItem;
            for (int i = 0; i < aviaries.Length; i++)
            {
                for(int j = 0; j < aviaries[i].animals.Length; j++)
                {
                    if(needed_animal_id == aviaries[i].animals[j].id)
                    {
                        aviaries[i].animals[j].eat(foods[(int)food_ids.SelectedIndex], place);
                        foods = foods.Where(f => f.id != needed_food_id).ToArray();
                        food_ids.Items.RemoveAt((int)food_ids.SelectedIndex);
                        return;
                    }
                }
            }
            
        }
        public void buy_animal(int animal_code, int aviary_id, ListBox listbox, Label place)
        {
            var logger = NLog.LogManager.GetCurrentClassLogger();

            if (animal_code == -1 || aviary_id == -1)
            {
                place.Text = lmanager.INVALID_DATA;
                logger.Info(place.Text);
                return;
            }
            place.Text = "";
            animal_id += 1;


            Func<Animal>[] factories = new Func<Animal>[2] { () => new Lion(animal_id), () => new Zebra(animal_id) };

            Animal animal = factories[animal_code]();

            if (aviaries[aviary_id].occupied_area + animal.get_needed_area() > aviaries[aviary_id].area) 
            {
                place.Text = lmanager.NoPlaceToBuyAnimalWarning;
                logger.Info(place.Text);
                return;
            }

            aviaries[aviary_id].animals = aviaries[aviary_id].animals.Append(animal).ToArray();
            aviaries[aviary_id].occupied_area += animal.get_needed_area();

            money -= animal.get_price();
            place.Text = lmanager.DealAccepted + '\n';
            place.Text += animal.get_type() + lmanager.WithName + animal.name + lmanager.LocatedInAviary + aviaries[aviary_id].id.ToString() + '\n';

            listbox.Items.Add(animal_id);

            Animal[] cornivores = aviaries[aviary_id].animals.Where(item => item is Cornivore).ToArray();
            Random rnd = new Random();
            if (cornivores.Length == 0) return;
            Cornivore cornivore = ((Cornivore)cornivores[rnd.Next(0, cornivores.Length)]);
            cornivore.hunt(aviaries[aviary_id], place, listbox);
            logger.Info(place.Text);

        }
        public void kill_animal(ListBox animals_lb, ListBox foods_lb, Label place)
        {
            var logger = NLog.LogManager.GetCurrentClassLogger();

            int needed_animal_id = (int)animals_lb.SelectedItem;
            for (int i = 0; i < aviaries.Length; i++)
            {
                for (int j = 0; j < aviaries[i].animals.Length; j++)
                {
                    if (needed_animal_id == aviaries[i].animals[j].id && aviaries[i].animals[j] is Cornivore)
                    {
                        place.Text = lmanager.ImpossibleToKillCornivore + aviaries[i].animals[j].name;
                        logger.Info(place.Text);
                        return;
                    }

                    if (needed_animal_id == aviaries[i].animals[j].id)
                    {
                        Herbivore h = (Herbivore)aviaries[i].animals[j];
                        Food new_food = new Meat(food_id, h.get_meatiness());
                        foods = foods.Append(new_food).ToArray();
                        place.Text = lmanager.Animal + h.name + lmanager.SlaughterForMeat;
                        logger.Info(place.Text);
                        animals_lb.Items.RemoveAt(animals_lb.Items.IndexOf(needed_animal_id));
                        foods_lb.Items.Add(new_food.id);
                        aviaries[i].remove_animal(needed_animal_id);
                        return;
                    }
                }
            }
        }
        public void deserialize(ListBox lb)
        {
            using (FileStream fs = new FileStream(serialization_path, FileMode.Open))
            {
                XmlSerializer serializer = new XmlSerializer(typeof(Food[]));
                foods = (Food[])serializer.Deserialize(fs);
                food_id = foods.Last().id;
            }
            for(int i = 0; i < foods.Length; i++)
            {
                lb.Items.Add(foods[i].id);
            }
        }
        public void serialize()
        {
            using (FileStream fs = new FileStream(serialization_path, FileMode.Create))
            {
                XmlSerializer serializer = new XmlSerializer(typeof(Food[]));
                serializer.Serialize(fs, foods);
            }
        }
    }
}
