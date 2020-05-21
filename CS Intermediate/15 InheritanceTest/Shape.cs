using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _15_InheritanceTest
{
    public abstract class Shape
    {
        public Shape()
        {
            this.ID = Guid.NewGuid();
        }
        protected Guid ID { get; private set; }
        public string Name { get; set; }

        public abstract void Draw();
    }
}
