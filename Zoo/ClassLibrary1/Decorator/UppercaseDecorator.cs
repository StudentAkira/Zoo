using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class UppercaseDecorator : Shell
    {
        public UppercaseDecorator(IDecorator decorator) : base(decorator) { }
        public override void Write_data(string data)
        {
            data = data.ToUpper();
            decorator.Write_data(data);
        }
    }
}
