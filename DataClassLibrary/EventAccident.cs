using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataClassLibrary
{
    interface EventAccident
    {
        // nie ma dostępu do klasy Card (pls help)
        //int Fire(Card cardToIgnite);
        int Flood();
        int EarthQuake();
        int Hurricane();
        int Storm();
        int Drought();

    }
}
