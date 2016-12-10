using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataObjects.Map
{
    public class Resource : IResource
    {
        public string Name { get; set; }

        public Resource()
        {
            Name = "";
        }
    }
}
