using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataObjects.Map
{
    public class Map
    {
        public List<Field> Fields { get; set; }

        public Map()
        {
            Fields = new List<Field>();
            InitializeMap();
            for (int i = 0; i < 5000; i++)
            {
                Fields.Add(new Field());
            }
            for (int i = 0; i < 3000; i++)
            {
                var pole = new Field();
                pole.Resource.Name = "Drewno";
                Fields.Add(pole);
            }
            for (int i = 0; i < 500; i++)
            {
                var pole = new Field();
                pole.Resource.Name = "Żelazo";
                Fields.Add(pole);
            }
            for (int i = 0; i < 500; i++)
            {
                var pole = new Field();
                pole.Resource.Name = "Złoto";
                Fields.Add(pole);
            }
            for (int i = 0; i < 500; i++)
            {
                var pole = new Field();
                pole.Resource.Name = "Kamień";
                Fields.Add(pole);
            }
            for (int i = 0; i < 500; i++)
            {
                var pole = new Field();
                pole.Resource.Name = "Węgiel";
                Fields.Add(pole);
            }
        }

        private void InitializeMap()
        {
            // Tutaj Panie Pawle trzeba zrobic 10000 pól i zapisac je do zmiennej Fields (ktora jest wyzej)
            // Mozesz tworzyc sobie funkcje pomocnicze. Nawet powinieneś ...
            // 1. sync + pull
            // 2. changes + commit
            // 3. sync + push
            for (int i = 0; i < 50; i++)
            {
                
            }
        }
    }
}
