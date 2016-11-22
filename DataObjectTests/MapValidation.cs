using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataObjects.Map;

namespace DataObjectTests
{
    class MapValidation
    {
        private Map _mapa { get; set; }

        public MapValidation()
        {
            _mapa = new Map();

        }
        public void Tests()
        {
            Console.WriteLine("Inicjalizuje mape");
            Console.WriteLine(" Test 1 (Ilość pól): {0}", Test1());
            Console.WriteLine(" Test 2 (Ilosc drewna): {0}", Test2());
            Console.WriteLine(" Test 3 (Ilosc złota): {0}", Test3());
            Console.WriteLine(" Test 4 (Ilosc wegla): {0}", Test4());
            Console.WriteLine(" Test 5 (Ilosc kamienia): {0}", Test5());
            Console.WriteLine(" Test 6 (Ilosc żelaza): {0}", Test6());
            Console.WriteLine(" Test 7 (Ilosc wszystkich surowców): {0}", Test7());
        }
        public bool WholeTest()
        {
            if (!Test1()) return false;
            if (!Test2()) return false;
            if (!Test3()) return false;
            if (!Test4()) return false;
            if (!Test5()) return false;
            if (!Test6()) return false;
            if (!Test7()) return false;

            return true;
        }
        
        private bool Test1()
        {
            var amount = _mapa.Fields.Select(n=>n).Count();
            if (amount == 10000) return true;
            else return false;
        }
        private bool Test2()
        {
            var amount = _mapa.Fields.Select(n => n.Resource).Where(x=>x.Name == "Drewno").Count();
            //Console.Write("Drewno: {0}",amount);
            if (amount >= 500 && amount <= 3000) return true;
            else return false;
        }
        private bool Test3()
        {
            var amount = _mapa.Fields.Select(n => n.Resource).Where(x => x.Name == "Złoto").Count();
            //Console.Write("Złoto: {0}", amount);
            if (amount >= 500 && amount <= 3000) return true;
            else return false;
        }
        private bool Test4()
        {
            var amount = _mapa.Fields.Select(n => n.Resource).Where(x => x.Name == "Węgiel").Count();
            //Console.Write("Węgiel: {0}", amount);
            if (amount >= 500 && amount <= 3000) return true;
            else return false;
        }
        private bool Test5()
        {
            var amount = _mapa.Fields.Select(n => n.Resource).Where(x => x.Name == "Kamień").Count();
            //Console.Write("Kamień: {0}", amount);
            if (amount >= 500 && amount <= 3000) return true;
            else return false;
        }
        private bool Test6()
        {
            var amount = _mapa.Fields.Select(n => n.Resource).Where(x => x.Name == "Żelazo").Count();
            //Console.Write("Żelazo: {0}", amount);
            if (amount >= 500 && amount <= 3000) return true;
            else return false;
        }
        private bool Test7()
        {
            var amount = _mapa.Fields.Select(n => n.Resource).Where(x => x.Name == " ").Count();
            //Console.Write("Puste: {0}", amount);
            if (amount == 5000) return true;
            else return false;
        }

    }
}
