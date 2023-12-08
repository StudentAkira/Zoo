using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp1
{
    public class ZooTextReader : Reader
    {
        static string path = @".\data\data.txt";
        public ZooTextReader() { }
        public override Zoo read_zoo(ListBox aviaries_lb, ListBox animals_lb)
        {
            Zoo zoo = new Zoo();
            zoo.money = int.Parse(System.IO.File.ReadAllText(path));
            return zoo;
        }
        public override Aviary read_aviary()
        {
            Aviary aviary = new Aviary();

            return aviary;
        }
        public override Animal read_animal()
        {
            Animal animal = new Animal();
            //Func<Animal>[] animals_creators = new Func<Animal>[2] { () => new Lion(), () => new Zebra() };
            //List<string> animals_types = new List<string>() { "LION", "ZEBRA" };
            //string animal_type = br.ReadString();
            //int needed_animal_index = animals_types.IndexOf(animal_type);

            //Animal animal = animals_creators[needed_animal_index]();

            //animal.id = br.ReadInt32();
            //animal.name = br.ReadString();
            //animal.age = br.ReadInt32();
            //animal.satiety = br.ReadInt32();

            return animal;
        }
    }
}
