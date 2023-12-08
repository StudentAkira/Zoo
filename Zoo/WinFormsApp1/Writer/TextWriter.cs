using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp1
{
    public class ZooTextWriter : Writer
    {
        static string path = @".\data\data.txt";
        Zoo zoo;
        public ZooTextWriter(Zoo zoo) 
        {
            this.zoo = zoo;
            System.IO.File.WriteAllText(path, string.Empty);
        }
        public override void write_zoo()
        {
            System.IO.File.WriteAllText(path, zoo.money.ToString());
        }
    }
}
