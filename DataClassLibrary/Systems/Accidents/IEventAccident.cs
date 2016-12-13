using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MainEngineAlfa.Objects;
namespace DataClassLibrary
{
    public interface IEventAccident
    {
        
        void Fire(ICard cardToIgnite);
        void Fire(ICard card1, ICard card2);
        void Fire(List<ICard> cardsPack);


        void Flood(ICard cardToSink);
        void Flood(ICard card1, ICard card2);
        void Flood(List<ICard> cardsPack);


        void EarthQuake(ICard cardToShake);
        void EarthQuake(ICard card1, ICard card2);
        void EarthQuake(List<ICard> cardsPack);

        void Hurricane(ICard cardToBlow);
        void Hurricane(ICard card1, ICard card2);
        void Hurricane(List<ICard> cardsPack);

        void Storm(ICard cardToStorm);
        void Storm(ICard card1, ICard card2);
        void Storm(List<ICard> cardsPack);

        void Drought(ICard cardToShake);
        void Drought(ICard card1, ICard card2);
        void Drought(List<ICard> cardsPack);

        int CheckAccidentPercentage(ICard cardToCheck);
        ICard CheckAccidentPercentage(ICard card1, ICard card2);
        ICard CheckAccidentPercentage(List<ICard> cardsPack);


    }
}
