using System;
using System.Security.Cryptography.X509Certificates;

namespace PBOB
{
    class Processor
    {
        public string Merk;
        public string Tipe;
        public Processor(string merk, string tipe)
        {
            this.Merk = merk;
            this.Tipe = tipe;
        }
    }
    class intel : Processor
    {
        public intel(string tipe) : base("intel", tipe) 
        { 
        
        }
    }
    class CoreI3 : intel
    {
        public CoreI3() : base("CoreI3")
        {

        }
    }
    class CoreI5 : intel
    {
        public CoreI5() : base("CoreI5")
        {

        }
    }
    class CoreI7: intel
    {
        public CoreI7() : base("CoreI7")
        {

        }
    }
    class AMD: Processor
    {
        public AMD(string tipe): base("AMD", tipe)
        {

        }
    }
    class Ryzen : AMD
    {
        public Ryzen() : base("Rayzen")
        {

        }
    }
    class Athlon : AMD
    {
        public Athlon() : base("Athlon")
        {

        }
    }

    class VGA
    {
        public string Merk;
        public VGA(string merk)
        {
            Merk = merk;
        }
    }
    class Nvidia : VGA
    {
        public Nvidia() : base("Nvidia")
        {

        }
    }
    class Amd : VGA
    {
        public Amd() : base("Amd")
        {

        }
    }
    class laptop
    {
        public string Merk;
        public string Tipe;
        public VGA vGA;
        public Processor processor;

        public laptop(string merk, string tipe, VGA _vga, Processor _processor)
        {
            Merk = merk;
            Tipe = tipe;
            vGA = _vga;
            processor = _processor;
           
        }

        public void Spesifikasi_dari_laptop()
        {
            Console.WriteLine("SPESIFIKASI: ");
            Console.WriteLine("Merk: " + this.Merk);
            Console.WriteLine("Tipe:"  + this.Tipe);
            Console.WriteLine($"Merk vGa: {this.vGA.Merk}");
            Console.WriteLine($"Merk processor: {this.processor.Merk}");
            Console.WriteLine($"Tipe processor: {this.processor.Tipe}");

        }

        public void LaptopDinyalakan()
        {
            Console.WriteLine($"laptop {Merk} {Tipe} menyala");
        }
        public void LaptopDimatikan()
        {
            Console.WriteLine($"Laptop {Merk} {Tipe} mati");
        }
    }

    class Asus : laptop
    {
        public Asus(string tipe, VGA vGa, Processor processor) : base("Asus", tipe, vGa, processor)
        {

        }
    }

    class Vivobook : Asus
    {
        public Vivobook(VGA vGa, Processor processor) : base("Vivobook", vGa, processor)
        {

        }
        public void Ngoding()
        {
            Console.WriteLine("Ctak Ctak Ctak, Error lagi!!");
        }
    }

    class ROG : Asus
    {
        public ROG(VGA vGa, Processor processor) : base("ROG", vGa, processor)
        {

        }
    }
    class Acer : laptop
    {
        public Acer(string tipe, VGA vGa, Processor processor) : base("Acer", tipe, vGa, processor) 
        {

        }
    }
    class Swift : Acer
    {
        public Swift(VGA vGa, Processor processor) : base("Swift", vGa, processor)
        {

        }
    }
    class Predator : Acer
    {
        public Predator(VGA vGa, Processor processor) : base ("predator", vGa, processor)
        {

        }
        public void BermainGame()
        {
            Console.WriteLine($"Laptop {Merk} {Tipe} sedang memainkan game");
        }
    }
    class Lenovo : laptop
    {
        public Lenovo(string tipe, VGA vGa, Processor processor) : base("Lenovo", tipe, vGa, processor)
        {

        }
    }
    class IdeaPad : Lenovo
    {
        public IdeaPad(VGA vGa, Processor processor) : base("IdeaPad", vGa, processor)
        {

        }
    }
    class Legion : Lenovo
    {
        public Legion(string tipe, VGA vGa, Processor processor) : base("Legion", vGa, processor)
        {

        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            laptop laptop1, laptop2;
            Predator predator;
            Acer acer;

            laptop1 = new Vivobook(new Nvidia(), new CoreI5());
            laptop2 = new IdeaPad(new Amd(), new Ryzen());
            predator = new Predator(new Amd(), new CoreI7());
            acer = new Predator(new Nvidia(), new CoreI3());

            //laptop2.LaptopDinyalakan();
            //laptop2.LaptopDimatikan();
            //laptop1.Ngoding();
            //predator.BermainGame();
            //laptop1.Spesifikasi_dari_laptop();
            //acer.BermainGame();
        }
    }
}