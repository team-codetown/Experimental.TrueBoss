using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MainEngineAlfa.Objects;

namespace DataClassLibrary
{
    public interface ICardActions
    {
        bool PlaceCard(ICard cardToPlace);
        bool PickUpCard(ICard cardToPick);
        bool SellCard(ICard cardToSell);
        bool BuyCard(ICard cardToBuy);
       
    }
}
