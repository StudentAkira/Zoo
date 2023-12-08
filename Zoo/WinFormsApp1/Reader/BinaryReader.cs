using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Xml.Linq;

namespace WinFormsApp1
{
    public class ZooBinaryReader : Reader
    {
        static string path = @".\data\data.dat";
        BinaryReader br = new BinaryReader(File.Open(path, FileMode.Open));
        public ZooBinaryReader()
        { 
        
        }
        public override Zoo read_zoo(ListBox aviaries_lb, ListBox animals_lb) 
        {
            Zoo zoo = new Zoo();
            aviaries_lb.Items.Clear();
            animals_lb.Items.Clear();

            zoo.aviaries = new Aviary[] { };

            
            zoo.money = br.ReadInt32();
            zoo.animal_id = br.ReadInt32();
            zoo.aviary_id = br.ReadInt32();
            while (br.BaseStream.Position != br.BaseStream.Length)
            {
                Aviary aviary = read_aviary();
                zoo.aviaries = zoo.aviaries.Append(aviary).ToArray();
                aviaries_lb.Items.Add(aviary.id);
                for (int i = 0; i < aviary.animals.Length; i++)
                {
                    animals_lb.Items.Add(aviary.animals[i].id);
                }
            }
            br.Close();
            return zoo;
        }
        public override Aviary read_aviary()
        {
            Aviary aviary = new Aviary();

            string object_type = br.ReadString();
            aviary.id = br.ReadInt32();
            aviary.area = br.ReadInt32();
            aviary.occupied_area = br.ReadInt32();
            int animals_cnt = br.ReadInt32();
            for (int i = 0; i < animals_cnt; i++)
            {
                Animal animal = read_animal();
                aviary.animals = aviary.animals.Append(animal).ToArray();
            }

            return aviary;
        }
        public override Animal read_animal()
        {
            Func<Animal>[] animals_creators = new Func<Animal>[2] { () => new Lion(), () => new Zebra() };
            List<string> animals_types = new List<string>() { "LION", "ZEBRA" };
            string animal_type = br.ReadString();
            int needed_animal_index = animals_types.IndexOf(animal_type);

            Animal animal = animals_creators[needed_animal_index]();

            animal.id = br.ReadInt32();
            animal.name = br.ReadString();
            animal.age = br.ReadInt32();
            animal.satiety = br.ReadInt32();

            return animal;
        }
    }
}
