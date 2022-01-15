using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleFactory
{
    public abstract class Pizza
    {
        protected string Name { get; set; }
        protected string Dough { get; set; }
        protected string Sauce { get; set; }

        public virtual void Prepare()
        {

        }
        public virtual void Bake()
        {

        }
        public virtual void Cut()
        {

        }
        public virtual void Box()
        {

        }

        public string getName()
        {
            return Name;
        }
    }
}
