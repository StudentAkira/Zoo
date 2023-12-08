using NLog;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace WinFormsApp1
{
    public class Aviary
    {
        public LocalizationManager lmanager;
        public int id;
        public int area;
        public int occupied_area;
        public Animal[] animals = new Animal[] { };
        public void init_lmanager()
        {
            Encoding.RegisterProvider(CodePagesEncodingProvider.Instance);
            string text = File.ReadAllText(LocalizationManager.path, LocalizationManager.encoding);
            lmanager = JsonSerializer.Deserialize<LocalizationManager>(text);
        }
        public Aviary(int area = 0, int id = 0) 
        {
            init_lmanager();
            this.id = id;
            this.area = area;
        }
        public void get_info(Label place) 
        {
            place.Text += lmanager.Aviary + '\n';
            place.Text += lmanager.AviaryId + id.ToString() + '\n';
            place.Text += lmanager.AviaryArea + area.ToString() + '\n';
            place.Text += lmanager.AviaryOccupitedArea + occupied_area.ToString() + '\n';
            place.Text += lmanager.AviaryAnimals + '\n';
            if (animals.Length == 0)
            {
                place.Text += lmanager.NO_DATA + '\n';
                return;
            }
            for (int i = 0; i < animals.Length; i++)
            {
                animals[i].get_info(place);
            }
            place.Text += '\n';
        }
        public void remove_animal(int id)
        {
            Animal a = (Animal)animals.Where(animal => animal.id == id).First();
            occupied_area -= a.get_needed_area();
            animals = animals.Where(animal => animal.id != id).ToArray();
        }
    }
}
