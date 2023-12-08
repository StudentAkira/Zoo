using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace WinFormsApp1
{
    public class Lion : Cornivore
    {
        
        public int needed_area = 50;
        public int needed_food = 60;
        public int price = 100;
        public int income = 100;
        public string type;
        public string binary_type = "LION";
        public void init_lmanager()
        {
            type = lmanager.LionName;
        }
        public Lion(int id = 0) : base(id) {}
        public Lion(BinaryReader br){ init_lmanager(); }
        public override string get_binary_type()
        {
            return binary_type;
        }
        public override void eat(Food food, Label place)
        {
            base.eat(food, place);
            if(this.satiety >= 100)this.satiety = 100;
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
            place.Text += lmanager.LionData + '\n';
            place.Text += lmanager.NeededArea + needed_area.ToString() + '\n';
            base.get_info(place);
        }
        public override int get_price()
        {
            return price;
        }
        public override int get_income()
        {
            return income;
        }
    }
}
