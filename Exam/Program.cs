using System;
using System.Linq;

namespace Exam
{
    class Program
    {
        static void Main(string[] args)
        {
            ILamp lamp = new PhotoStudio("Fluorescent", "Atom", 5, "Threaded", 2);
            ICamera camera = new PhotoStudio("Film camera", "Sony", 100);
            Console.WriteLine("Lamp:");
            lamp.PrintType();
            lamp.PrintProducer();
            lamp.PrintPower();
            lamp.PrintElementsType();
            lamp.PrintElementsAmount();
            Console.WriteLine("====================");
            Console.WriteLine("Camera:");
            camera.PrintType();
            camera.PrintProducer();
            camera.PrintPhotosensitivity();
            camera.ChangePhotosensitivity(200);
            Console.WriteLine("====================");
            Console.WriteLine("New Photosensitivity: ");
            camera.PrintPhotosensitivity();
        }
    }

    interface ILamp
    {
        string Type { get; set; }
        string Producer { get; set; }
        double Power { get; set; }
        string ElementsType { get; set; }
        ushort ElementsAmount { get; set; }

        void PrintType();
        void PrintProducer();
        void PrintPower();
        void PrintElementsType();
        void PrintElementsAmount();
        void ChangePower(double newPower);
    }

    interface ICamera
    {
        string Type { get; set; }
        string Producer { get; set; }
        double Photosensitivity { get; set; }
        void PrintType();
        void PrintProducer();
        void PrintPhotosensitivity();
        void ChangePhotosensitivity(double newPhotosensitivity);
    }

    class PhotoStudio : ILamp, ICamera
    {
        public PhotoStudio(string type, string producer, double power, string elementsType, ushort elementsAmount)
        {
            Type = type;
            Producer = producer;
            Power = power;
            ElementsType = elementsType;
            ElementsAmount = elementsAmount;
        }
        public PhotoStudio(string type, string producer, double photosensitivity)
        {
            Type = type;
            Producer = producer;
            Photosensitivity = photosensitivity;
        }
        public string Type { get; set; }
        public string Producer { get; set; }
        public double Power { get; set; }
        public string ElementsType { get; set; }
        public ushort ElementsAmount { get; set; }
        public double Photosensitivity { get; set; }

        public void ChangePower(double newPower)
        {
            Power = newPower;
        }
        public void ChangePhotosensitivity(double newSensitivity)
        {
            Photosensitivity = newSensitivity;
        }
        public void PrintElementsAmount()
        {
            Console.WriteLine($"ElementsAmount: {ElementsAmount}");
        }

        public void PrintElementsType()
        {
            Console.WriteLine($"ElementsType: {ElementsType}");
        }

        public void PrintPower()
        {
            Console.WriteLine($"Power: {Power}");
        }
        public void PrintPhotosensitivity()
        {
            Console.WriteLine($"Photosensitivity: {Photosensitivity}");
        }
        public void PrintProducer()
        {
            Console.WriteLine($"Producer: {Producer}");
        }

        public void PrintType()
        {
            Console.WriteLine($"Type: {Type}");
        }
    }
}

