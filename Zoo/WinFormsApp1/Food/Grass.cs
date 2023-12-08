using NLog;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Xml.Linq;
using System.Xml.Serialization;

namespace WinFormsApp1
{
    [Serializable]
    public class Grass : Food
    {
        public Grass(int id = 0, int efficiency = 20) : base(id)
        {
            this.type = "Grass";
            this.price = 20;
            this.efficiency = efficiency;
        }
        public Grass() 
        {
            init_lmanager();
            this.type = "Grass";
            this.price = 20;
            this.efficiency = 20;
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
