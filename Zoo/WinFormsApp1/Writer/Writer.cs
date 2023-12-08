using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp1
{
    public class Writer
    {
        public Writer() { }
        public virtual void write_zoo() { }
        public virtual void write_animal(Animal animal) { }
        public virtual void write_aviary(Aviary aviary) { }
    }
}
