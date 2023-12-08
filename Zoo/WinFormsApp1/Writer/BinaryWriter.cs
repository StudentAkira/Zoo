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
    public class ZooBinaryWriter : Writer
    {
        static string path = @".\data\data.dat";
        BinaryWriter bw;
        Zoo zoo;
        public ZooBinaryWriter(Zoo zoo) 
        {
            this.zoo = zoo;
            System.IO.File.WriteAllText(path, string.Empty);
            bw = new BinaryWriter(File.Open(path, FileMode.Open));
        }
        public override void write_zoo()
        {
            bw.Write(zoo.money);
            bw.Write(zoo.animal_id);
            bw.Write(zoo.aviary_id);
            for (int i = 0; i < zoo.aviaries.Length; i++)
            {
                write_aviary(zoo.aviaries[i]);
                for (int j = 0; j < zoo.aviaries[i].animals.Length; j++)
                {
                    write_animal(zoo.aviaries[i].animals[j]);
                }
            }
            bw.Close();
            
        }
        public override void write_animal(Animal animal)
        {
            bw.Write(animal.get_binary_type());
            bw.Write(animal.id);
            bw.Write(animal.name);
            bw.Write(animal.age);
            bw.Write(animal.satiety);
        }
        public override void write_aviary(Aviary aviary)
        {
            bw.Write("AVIARY");
            bw.Write(aviary.id);
            bw.Write(aviary.area);
            bw.Write(aviary.occupied_area);
            bw.Write(aviary.animals.Length);
        }
    }
}
