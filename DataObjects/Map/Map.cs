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

            for (int i = 0; i < 100; i++)
            {
                for (int j = 0; j < 100; j++)
                {

                    var pole = new Field();
                    pole.Resource.Name = "";
                    pole.cordX = j;
                    pole.cordY = i;
                    Fields.Add(pole);

                }
            }

            Fields = MapGenerator.GenerateMap();
            InitializeMap();
            //for (int i = 0; i < 5000; i++)
            //{
            //    Fields.Add(new Field());
            //}
            //for (int i = 0; i < 3000; i++)
            //{
            //    var pole = new Field();
            //    pole.Resource.Name = "Drewno";
            //    Fields.Add(pole);
            //}
            //for (int i = 0; i < 500; i++)
            //{
            //    var pole = new Field();
            //    pole.Resource.Name = "Żelazo";
            //    Fields.Add(pole);
            //}
            //for (int i = 0; i < 500; i++)
            //{
            //    var pole = new Field();
            //    pole.Resource.Name = "Złoto";
            //    Fields.Add(pole);
            //}
            //for (int i = 0; i < 500; i++)
            //{
            //    var pole = new Field();
            //    pole.Resource.Name = "Kamień";
            //    Fields.Add(pole);
            //}
            //for (int i = 0; i < 500; i++)
            //{
            //    var pole = new Field();
            //    pole.Resource.Name = "Węgiel";
            //    Fields.Add(pole);
            //}
        }

        private void InitializeMap()
        {
            // Tutaj Panie Pawle trzeba zrobic 10000 pól i zapisac je do zmiennej Fields (ktora jest wyzej)
            // Mozesz tworzyc sobie funkcje pomocnicze. Nawet powinieneś ...
            // 1. sync + pull
            // 2. changes + commit
            // 3. sync + push
          
        }
    }

    static public class MapGenerator
    {
        static Random rand = new Random();

        static public List<Field> GenerateMap()
        {

            List<Field> Fields = new List<Field>();
            string[,] Map = new string[100, 100];
            //Map[1, 1] = PolaMapy.Woda;

            object[] Pola = new object[6];

            Pola[0] = "Węgiel";
            Pola[1] = "Drewno";
            Pola[2] = "Żelazo";
            Pola[3] = "Złoto";
            Pola[4] = "Kamień";
            Pola[5] = "Woda";
            int losujX = 0;
            int losujY = 0;

            bool emptyMap;

            // losowanie 5% każdego surowca, czyli 25 % mapy juz zajete
            for (int j = 0; j < 500; j++)
            {
                for (int i = 0; i < 5; i++)
                {
                    do
                    {
                        losujWspolrzedne(ref losujX, ref losujY);
                        emptyMap = true;


                        if (Map[losujX, losujY] != null)
                        {
                            emptyMap = false;

                            continue;
                        }

                        var pole = new Field();
                        
                        pole.Resource.Name = Pola[i].ToString();
                        pole.cordX = losujX;
                        pole.cordY = losujY;
                        Fields.Add(pole);

                    } while (emptyMap == false);  //zabezpieczenie przed przypisaniem surowca do pola na ktorym jest juz surowiec

                }
            }

            // losowanie pozostałych 25%
            for (int i = 0; i < 2500; i++)
            {
                do
                {
                    emptyMap = true;
                    losujWspolrzedne(ref losujX, ref losujY);
                    int losujSurowiec = rand.Next(0, 5);


                    if (Map[losujX, losujY] != null)
                    {
                        emptyMap = false;
                        continue; ;
                    }

                    var pole = new Field();
                    pole.Resource.Name = Pola[losujSurowiec].ToString();
                    pole.cordX = losujX;
                    pole.cordY = losujY;
                    Fields.Add(pole);

                } while (emptyMap == false);
            }

            return Fields;


        }


        private static void losujWspolrzedne(ref int losujX, ref int losujY)
        {

            // ograniczenie prawdopodobienstwa wylosowania w srodku
            // pole powierzchni okolic ratusza = 64 kratki

            do
            {
                losujX = rand.Next(0, 100);
                losujY = rand.Next(0, 100);

            } while ((losujX >= 49 && losujX <= 50) && (losujY >= 49 && losujY <= 50));


            if ((losujX >= 46 && losujX <= 53) && (losujY >= 46 && losujY <= 53))
            {
                do
                {
                    losujX = rand.Next(0, 100);
                    losujY = rand.Next(0, 100);
                } while ((losujX >= 49 && losujX <= 50) && (losujY >= 49 && losujY <= 50));
            }
            else
            {

            }

        }
    }
}
