using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class NoDigitDecorator : Shell
    {
        public NoDigitDecorator(IDecorator decorator) : base(decorator) { }
        public override void Write_data(string data)
        {
            data = Regex.Replace(data, @"[\d-]", string.Empty);
            decorator.Write_data(data);
        }
    }
}
