using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
        }
    }
    class Computer
    {
        public string RAM { get; set; }
        public string HDD { get; set; }
        public string Keyboard { get; set; }
        public string Monitor { get; set; }
    }
    abstract class AbstractBuilder
    {
        public Computer computer = new Computer();
        public abstract void createRam();
        public abstract void createHDD();
        public abstract void createKeyboard();
        public abstract void createMonitor();
    }
    class AcerBuilder : AbstractBuilder
    {
        public override void createHDD()
        {
            computer.HDD = "Acer Hard Drive";
        }

        public override void createKeyboard()
        {
            computer.Keyboard = "Acer Hard Drive";
        }

        public override void createMonitor()
        {
            computer.Monitor = "Acer Monitor";
        }

        public override void createRam()
        {
            computer.RAM = "Acer RAM";
        }
    }
    class AsusBuilder : AbstractBuilder
    {
        public override void createHDD()
        {
            computer.HDD = "Asus Hard Drive";
        }

        public override void createKeyboard()
        {
            computer.Keyboard = "Asus Hard Drive";
        }

        public override void createMonitor()
        {
            computer.Monitor = "Asus Monitor";
        }

        public override void createRam()
        {
            computer.RAM = "Asus RAM";
        }
    }
    class Director
    {
        Computer createPC(AbstractBuilder a)
        {
            a.createKeyboard();
            a.createHDD();
            a.createMonitor();
            a.createRam();
            return a.computer;
        }
    }
}
