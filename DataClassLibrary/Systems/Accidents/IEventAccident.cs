using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataClassLibrary
{
    public interface IEventAccident
    {
        // nie ma dostępu do klasy Card (pls help)
        //int Fire(Card cardToIgnite);
        //muahahahaha
        int Flood();
        int EarthQuake();
        int Hurricane();
        int Storm();
        int Drought();

    }
}
