

//Задача Фабрика телефонов
using System;

namespace AbstractFactory
{
    public interface ITelephoneFactory
    {
        IDisplay CreateDisplay();
        IAccumulator CreateAccumulator();

        string FactoryName();
    }

    public interface IAccumulator
    {
        string AccumulatorModel();
    }

    public interface IDisplay
    {
        string DisplayModel();
        string AccumulatorType();

    }

    class SamsungAccumulator : IAccumulator
    {
        public SamsungAccumulator()
        {
            AccumulatorModel();
        }
        public string AccumulatorModel()
        {
            return "Акумулятор для телефона Samsung";
        }
    }

    class NokiaAccumulator : IAccumulator
    {
        public NokiaAccumulator()
        {
            AccumulatorModel();
        }
        public string AccumulatorModel()
        {
            return "Акумулятор для телефона Nokia";
        }
    }

    class NokiaDisplay : IDisplay
    {
        public NokiaDisplay()
        {
            DisplayModel();
        }

        public string AccumulatorType()
        {
            return "Nokia 123";
        }

        public string DisplayModel()
        {
            return "Дисплей для телефона Nokia";
        }
    }
    class SamsungDisplay : IDisplay
    {
        public SamsungDisplay()
        {
            DisplayModel();
        }

        public string AccumulatorType()
        {
            return "Samsung 123";
        }

        public string DisplayModel()
        {
            return "Дисплей для телефона Samsung";
        }
    }

    class Samsung : ITelephoneFactory
    {
        public string Name { get; set; }
        public Samsung(string name)
        {
            Name = name;
        }
        public IAccumulator CreateAccumulator()
        {
            return new SamsungAccumulator();
        }

        public IDisplay CreateDisplay()
        {
            return new SamsungDisplay();
        }

        public string FactoryName()
        {
            return Name;
        }
    }

    class Nokia : ITelephoneFactory
    {
        public string Name { get; set; }
        public Nokia(string name)
        {
            Name = name;
        }
        public IAccumulator CreateAccumulator()
        {
            return new NokiaAccumulator();
        }

        public IDisplay CreateDisplay()
        {
            return new NokiaDisplay();
        }

        public string FactoryName()
        {
            return Name;
        }
    }


    class Program
    {
        static void Main(string[] args)
        {
            ITelephoneFactory nokia = new Nokia("Nokia");
            ITelephoneFactory samsung = new Samsung("Samsung");

            Console.WriteLine($"В фабрике {nokia.FactoryName()} -  {nokia.CreateAccumulator().AccumulatorModel()}, {nokia.CreateDisplay().DisplayModel()}");
            Console.WriteLine($"Тип аккумулятора {nokia.CreateDisplay().AccumulatorType()}");
            Console.WriteLine("******************************");
            Console.WriteLine($"В фабрике {samsung.FactoryName()} -  {samsung.CreateAccumulator().AccumulatorModel()}, {samsung.CreateDisplay().DisplayModel()}");
            Console.WriteLine($"Тип аккумулятора {samsung.CreateDisplay().AccumulatorType()}");
        }
    }
}
