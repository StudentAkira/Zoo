using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class Decorator : IDecorator
    {
        public Decorator() { }
        public void Write_data(string data) 
        {
            string path = @"..\..\..\..\data\result.txt";
            File.WriteAllText(path, data + "\n");
        }
    }
}
