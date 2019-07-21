using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComputerFactory
{
    abstract class ComputerFac
    {
        public string Name { get; set; }
        public ComputerFac(string name)
        {
            Name = name;
        }
        public abstract IMainboard CreateMainbord();

        public abstract IProcessor CreateProcessor();

        public void Info()
        {
            Console.WriteLine($"на заводе {Name} выпускается {CreateMainbord().MainbordModel()} и {CreateProcessor().ProcessorModel()}. {CreateMainbord().ProcessorType()}");
        }
    }

    public interface IProcessor
    {
        string ProcessorModel();
    }

    public interface IMainboard
    {
        string MainbordModel();
        string ProcessorType();
    }

    class SonyMainboard : IMainboard
    {
        public string MainbordModel()
        {
            return "самая современная мат.плата для Sony";
        }


        public string ProcessorType()
        {
            return "Тип процессора: Intel для Sony";
        }
    }

    class DellMainboard : IMainboard
    {
        public string MainbordModel()
        {
            return "самая современная мат.плата для Dell";
        }


        public string ProcessorType()
        {
            return "Тип процессора: Intel для Dell";
        }
    }

    class DellProcessor : IProcessor
    {
        public string ProcessorModel()
        {
            return "8-ми ядерный процессор для Dell";
        }
    }

    public class SonyProcessor : IProcessor
    {
        public string ProcessorModel()
        {
            return "8-ми ядерный процессор для Sony";
        }
    }


    class Dell : ComputerFac
    {
        public Dell(string name) : base(name)
        {
        }

        public override IMainboard CreateMainbord()
        {
            return new DellMainboard();
        }

        public override IProcessor CreateProcessor()
        {
            return new DellProcessor();
        }
    }

    class Sony : ComputerFac
    {
        public Sony(string name) : base(name)
        {
        }

        public override IMainboard CreateMainbord()
        {
            return new SonyMainboard();
        }

        public override IProcessor CreateProcessor()
        {
            return new SonyProcessor();
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            ComputerFac sony = new Sony("Sony");
            ComputerFac dell = new Dell("Dell");

            sony.Info();
            dell.Info();
        }
    }
}
