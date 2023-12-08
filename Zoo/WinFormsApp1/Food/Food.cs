using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace WinFormsApp1
{
    [XmlInclude(typeof(Grass))]
    [XmlInclude(typeof(Meat))]
    [Serializable]
    public class Food
    {
        public LocalizationManager lmanager;
        public int id;
        public string type;
        public int price;
        public int efficiency;

        public void init_lmanager()
        {
            Encoding.RegisterProvider(CodePagesEncodingProvider.Instance);
            string text = File.ReadAllText(LocalizationManager.path, LocalizationManager.encoding);
            lmanager = JsonSerializer.Deserialize<LocalizationManager>(text);
        }
        public Food(int id = 0) 
        {
            init_lmanager();
            this.id = id;
        }
        public Food() { init_lmanager(); }
        public virtual void get_info(Label place) 
        {
            place.Text += lmanager.Food + '\n';
            place.Text += lmanager.Id + id.ToString() + '\n';

        }
        public virtual string get_type() { return ""; }
        public virtual int get_price() { return 0; }
    }
}
