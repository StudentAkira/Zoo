using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace WinFormsApp1
{
    public class Herbivore : Animal
    {
        public int meatiness;
        public Herbivore(int id = 0) : base(id) { }
        public virtual int play(Label place) { return 0; }
        public override void eat(Food food, Label place)
        {
            if (!(food is Grass))
            {
                place.Text = get_type() + " " + name + lmanager.DontWannaEat + food.get_type() + lmanager.StillHungry;
                return;
            }
            this.satiety += ((Grass)(food)).efficiency;
            base.eat(food, place);
        }
        public virtual int get_meatiness() { return 0; }
    }
}
