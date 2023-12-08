using NLog;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace WinFormsApp1
{

    [Serializable]
    public class Meat : Food
    {
        public Meat(int id = 0, int efficiency = 40) : base(id)
        {
            this.type = "Meat";
            this.price = 40;
            this.efficiency = efficiency;
        }
        public Meat()
        {
            init_lmanager();
            this.type = "Meat";
            this.price = 40;
            this.efficiency = 40;
        }
        public override void get_info(Label place)
        {
            base.get_info(place);
            place.Text += lmanager.Type + type + '\n';
            place.Text += lmanager.Efficiency + efficiency.ToString() + '\n';
        }
        public override string get_type()
        {
            return type;
        }
        public override int get_price() { return price; }
    }
}
