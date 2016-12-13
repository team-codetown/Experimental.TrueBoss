using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MainEngineAlfa.Objects;

namespace DataClassLibrary
{
    public interface IExtraction
    {
        
        double CaltulateMineExtraction(ICard mineCard);
        double CaltulateMineExtraction(List<ICard> cardPack);
        ICard CaltulateMineExtraction(ICard Card1, ICard Card2);


    }
}
