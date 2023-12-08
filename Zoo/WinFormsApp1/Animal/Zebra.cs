using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace WinFormsApp1
{
    public class Zebra : Herbivore
    {
        public int needed_area = 30;
        public int needed_food = 30;
        public int price = 50;
        public int income = 10;
        public string type;
        public string binary_type = "ZEBRA";
        private int meatiness = 80;
        public void init_lmanager()
        {
            type = lmanager.ZebraName;
        }
        public Zebra(int id = 0) : base(id) { }
        public Zebra(BinaryReader br) { init_lmanager(); }
        public override string get_binary_type()
        {
            return binary_type;
        }
        public override int play(Label place)
        {
            Random rnd = new Random();
            int tips = rnd.Next(1, 100);
            place.Text += lmanager.ZebraName + name + lmanager.AnimalId + id + lmanager.AnimalPlay + tips + lmanager.Tips + '\n';
            return tips;
        }
        public override void eat(Food food, Label place)
        {
            base.eat(food, place);
            if (this.satiety >= 50) this.satiety = 50;
        }
        public override int get_needed_area()
        {
            return needed_area;
        }
        public override int get_needed_food()
        {
            return needed_food;
        }
        public override string get_type()
        {
            return type;
        }
        public override void get_info(Label place)
        {
            place.Text += lmanager.ZebraData + '\n';
            place.Text += lmanager.NeededArea + needed_area.ToString() + '\n';
            place.Text += lmanager.AnimalSatiety + meatiness.ToString() + '\n';
            base.get_info(place);
        }
        public override int get_price()
        {
            return price;
        }
        public override int get_meatiness() { return meatiness; }
        public override int get_income()
        {
            return income;
        }
    }
}
