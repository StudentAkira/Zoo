using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace WinFormsApp1
{
    public class Cornivore : Animal
    {
        public Cornivore(int id = 0) : base(id) {}
        public virtual void hunt(Aviary aviary, Label place, ListBox listbox) 
        {
            Animal[] herbivores = aviary.animals.Where(item => item is Herbivore).ToArray();

            if (herbivores.Length == 0) { return; }
            place.Text += lmanager.Oops + '\n';
            for (int i = 0; i < herbivores.Length; i++)
            {
                this.eat(new Meat(0, ((Herbivore)herbivores[i]).get_meatiness()), place);
                place.Text += name + lmanager.JustEaten + herbivores[i].get_type() + " " + herbivores[i].name + lmanager.LooksVeryHappy + '\n';
                aviary.remove_animal(herbivores[i].id);
                listbox.Items.RemoveAt(listbox.Items.IndexOf(herbivores[i].id));
            }
        }
        public override void eat(Food food, Label place)
        {
            if (!(food is Meat))
            {
                place.Text = get_type() + " " + name + lmanager.DontWannaEat+ food.get_type() + lmanager.StillHungry;   
                return;
            }
            this.satiety += ((Meat)(food)).efficiency;
            base.eat(food, place);

        }
    }
}
