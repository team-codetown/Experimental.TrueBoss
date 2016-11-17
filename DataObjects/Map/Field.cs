using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataObjects.Map
{
    public class Field
    {
        public int cordX { get; set; }
        public int cordY { get; set; }
        public Resource Resource { get; set; }

        public Field()
        {
            Resource = new Resource();
        }
    }
}
