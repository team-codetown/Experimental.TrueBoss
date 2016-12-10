using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataObjects.Map
{

    public class Map : IMap
    {
        public List<Field> Fields { get; set; }
        public Random Seed { get; set; }
        private int[] ilosciSurowcow;

        public Map()
        {
            Fields = new List<Field>();
            Seed = new Random();

            for (int i = 1; i <= 100; i++)
            {
                for (int j = 1; j <= 100; j++)
                {

                    var pole = new Field();
                    pole.Resource.Name = " ";
                    pole.cordX = j;
                    pole.cordY = i;
                    Fields.Add(pole);
                }
            }

            InitializeMap();
        }

        private void InitializeMap()
        {
            var listaProporcji = randomizeProportions();
            ilosciSurowcow = new int[5];
            var j = 0;
            foreach (var item in listaProporcji)
            {
                ilosciSurowcow[j] = item.Value;
                j++;
            }
            var listaPunktow = randomizePoints();
            listaPunktow.Remove(listaPunktow.First());

            var i = 0;
            j = 0;
            foreach (var item in listaProporcji)
            {
                SetResource(item.Key, j, listaPunktow[i]);
                SetResource(item.Key, j, listaPunktow[i + 1]);
                SetResource(item.Key, j, listaPunktow[i+2]);
                SetResource(item.Key, j, listaPunktow[i + 3]);
                i += 4;
                j++;
            }

            //DrawMap();
        }

        private void DrawMap()
        {
            for (int i = 1; i <= 100; i++)
            {
                var list = Fields.Select(n => n).Where(x => x.cordY == i).OrderBy(n => n.cordX).ToList();
                foreach (var item in list)
                {
                    Console.Write(item.Resource.Name[0]);
                }
                Console.WriteLine();
            }
        }

        private void SetResource(string key, int v, Point point)
        {
            if (ilosciSurowcow[v] > 0)
            {
            if (point.X > 100) return;
            if (point.Y > 100) return;
            if (point.X < 1) return;
            if (point.Y < 1) return;
            var pole = Fields.Where(n => n.cordX == point.X && n.cordY == point.Y).First();
            if (pole.Resource.Name != " ") return;
            Fields.Remove(pole);
            pole.Resource.Name = key;
            Fields.Add(pole);
            ilosciSurowcow[v] -= 1;
            //if (v == 0) Console.WriteLine(ilosciSurowcow[v]);
                SetResource(key, v, new Point(point.X + 1, point.Y));
                SetResource(key, v, new Point(point.X, point.Y + 1));
                SetResource(key, v, new Point(point.X - 1, point.Y));
                SetResource(key, v, new Point(point.X, point.Y - 1));
            }
        }

        private List<Point> randomizePoints()
        {
            var list = new List<Point>();
            var bestList = new List<Point>();
            double bestDistance = 0;
            list.Add(new Point(50, 50));

            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 20; j++)
                {
                    list.Add(new Point(Seed.Next(100) + 1, Seed.Next(100) + 1));
                }
                if (bestDistance < SumOfDistances(list))
                {
                    bestList = new List<Point>();
                    bestList = list;
                    bestDistance = SumOfDistances(list);
                }
                list = new List<Point>();
                list.Add(new Point(50, 50));
            }
            return bestList;
        }

        private double SumOfDistances(List<Point> listaPunktow)
        {
            var suma = 0.0;
            foreach (var item1 in listaPunktow)
            {
                foreach (var item2 in listaPunktow)
                {
                    suma += distance(item1, item2);
                }
            }
            return suma;
        }

        private Dictionary<string, int> randomizeProportions()
        {
            string[] nazwySurowca = { "Drewno", "Złoto", "Węgiel", "Kamień", "Żelazo" };
            int[] ilosciSurowca = new int[5];
            for (int i = 0; i < 5; i++)
                ilosciSurowca[i] += 500;
            int surowiecLeft = 2500;
            while (surowiecLeft > 0)
            {
                int gdzie = Seed.Next(5);
                int ile = Seed.Next(surowiecLeft + 1);
                ilosciSurowca[gdzie] += ile;
                surowiecLeft -= ile;
            }
            var slownik = new Dictionary<string, int>();
            for (int i = 0; i < 5; i++)
                slownik.Add(nazwySurowca[i], ilosciSurowca[i]);
            return slownik;
        }

        private double distance(Point P1, Point P2)
        {
            return Math.Sqrt(Math.Pow(P2.X - P1.X, 2) + Math.Pow(P2.Y - P1.Y, 2));
        }

    }

}
