using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoFactory
{
    public interface ICar
    {
        IEngine CreateEngine();
        IBody CreateBody();

        string AutoName();
    }

    public interface IBody
    {
        string BodyModel();
        string EngineType();
    }

    public interface IEngine
    {
        string EngineModel();
    }


    public class FordEngine : IEngine
    {
        public FordEngine()
        {
            EngineModel();
        }
        public string EngineModel()
        {
            return "Мощный двигатель для Ford";
        }
    }

    public class ToyotaEngine : IEngine
    {
        public ToyotaEngine()
        {
            EngineModel();
        }
        public string EngineModel()
        {
            return "Простой двигатель для Toyota";
        }
    }

    public class ToyotaBody : IBody
    {
        public ToyotaBody()
        {
            BodyModel();
        }
        public string BodyModel()
        {
            return "Обтекаемый кузов Toyota";
        }

        public string EngineType()
        {
            return " и при чем тип двигателя 4VD";
        }
    }

    public class FordBody : IBody
    {
        public FordBody()
        {
            BodyModel();
        }
        public string BodyModel()
        {
            return "Громадный кузов Ford";
        }

        public string EngineType()
        {
            return "и при чем тип двигателя 2Q";
        }
    }

    class Ford : ICar
    {
        public string Name { get; set; }
        public Ford()
        {
            Name = "Ford";
        }
        public IBody CreateBody()
        {
            return new FordBody();
        }

        public IEngine CreateEngine()
        {
            return new FordEngine();
        }
        public string AutoName()
        {
            return Name;
        }
    }

    class Toyota : ICar
    {
        public string Name { get; set; }
        public Toyota()
        {
            Name = "Toyota";
        }
        public IBody CreateBody()
        {
            return new ToyotaBody();
        }

        public IEngine CreateEngine()
        {
            return new ToyotaEngine();
        }

        public string AutoName()
        {
            return Name;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            ICar Ford = new Ford();
            ICar Toyota = new Toyota();

            Console.WriteLine($"На заводе {Ford.AutoName()} выпускают {Ford.CreateBody().BodyModel()} и {Ford.CreateEngine().EngineModel()} {Ford.CreateBody().EngineType()}");
            Console.WriteLine($"***********************************************************************************");
            Console.WriteLine($"На заводе {Toyota.AutoName()} выпускают {Toyota.CreateBody().BodyModel()} и {Toyota.CreateEngine().EngineModel()} {Ford.CreateBody().EngineType()}");
        }
    }
}
