using ClassLibrary1;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace WinFormsApp1
{
    public class Animal
    {
        public LocalizationManager lmanager;
        NameGenerator ng = new NameGenerator();
        public int id;
        public string name;
        public int age;
        public int satiety;

        static public int a = 3;
        public void init_lmanager()
        {
            Encoding.RegisterProvider(CodePagesEncodingProvider.Instance);
            string text = File.ReadAllText(LocalizationManager.path, LocalizationManager.encoding);
            lmanager = JsonSerializer.Deserialize<LocalizationManager>(text);
            ng.init_lmanager();
        }
        public Animal(int id = 0) 
        {
            init_lmanager();
            this.id = id;
            Random rnd = new Random();
            name = ng.generate_name();
            age = rnd.Next(1, 20);
            satiety = 100;
        }
        public virtual string get_binary_type() { return ""; } 
        public virtual void eat(Food food, Label place) {

            place.Text += this.get_type() + lmanager.Eaten + '\n';
        }
        public virtual int get_needed_area() { return 0; }
        public virtual int get_needed_food() { return 0; }
        public virtual string get_type() { return ""; } 
        public virtual void get_info(Label place) 
        {
            place.Text += lmanager.AnimalId + id.ToString() + '\n';
            place.Text += lmanager.AnimalName+ name.ToString() + '\n';
            place.Text += lmanager.AnimalAge + age.ToString() + '\n';
            place.Text += lmanager.AnimalSatiety + satiety.ToString() + '\n';
        }
        public virtual int get_price() { return 0; }
        public virtual int get_income() { return 0; }
        public void death(Label place)
        {
            place.Text += lmanager.AfterLongDay + name + lmanager.DiedOfHunger + '\n';
            GC.SuppressFinalize(this);
        }
    }
}
