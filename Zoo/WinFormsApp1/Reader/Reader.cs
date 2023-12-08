using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp1
{
    public class Reader
    {
        public Reader() { }
        public virtual Zoo read_zoo(ListBox aviaries_lb, ListBox animals_lb) { return new Zoo(); }
        public virtual Aviary read_aviary() { return new Aviary(); }
        public virtual Animal read_animal() { return new Animal(); }
    }
}
