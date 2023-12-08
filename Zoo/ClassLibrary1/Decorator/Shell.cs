using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public abstract class Shell : IDecorator
    {
        protected IDecorator decorator;
        public Shell(IDecorator decorator) => this.decorator = decorator;
        public virtual void Write_data(string data) => decorator.Write_data(data);
    }
}
