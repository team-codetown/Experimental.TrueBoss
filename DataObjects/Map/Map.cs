using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataObjects.Map
{
    class Map
    {
        public List<Field> Fields { get; set; }

        public Map()
        {
            Fields = new List<Field>();
        }
    }
}
