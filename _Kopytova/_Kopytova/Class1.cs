using System;
using System.Collections.Generic;
using System.Text;

namespace _Kopytova
{
    public class Class1
    {

        public string i_Nomer { get; set; }
        public string naz { get; set; }
        public string color { get; set; }
        public string ispol { get; set; }

        public virtual void WarningSound()
        {
            Console.WriteLine("Устройство подаёт сигнал");
        }
    }

    public class Thermometer : Class1
    {
        private double temperatura { get; set; }

        public void TempSearch()
        {
            temperatura = new Random().Next(36, 40);
            Console.WriteLine($"Температура = {temperatura}");
        }
        public override void WarningSound()
        {
            Console.WriteLine("Мигает");
        }
    }
    public class Weight : Class1
    {
        private double ves { get; set; }

        public void WeightSearch()
        {
            ves = new Random().Next(50, 75);
            Console.WriteLine($"Вес = {ves}");
        }

        public override void WarningSound()
        {
            Console.WriteLine("Издает звук");
        }
    }

    public class Barometr : Class1
    {
        private double davlenie { get; set; }

        public void BarSearch()
        {
            davlenie = new Random().Next(50, 75);
            Console.WriteLine($"Давление = {davlenie}");
        }
        public override void WarningSound()
        {
            Console.WriteLine("Свистит");
        }
    }
}
