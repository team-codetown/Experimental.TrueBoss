using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MainEngineAlfa.Objects;

namespace DataClassLibrary
{
    public interface IError
    {
        void CardActionsError(ICard card);
        // czy ma zwracac string? 
    }
}
