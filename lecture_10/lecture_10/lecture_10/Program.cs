using System;

namespace lecture_10
{
    class Program
    {
        static void Main(string[] args)
        {
            //Moto 1
            Motorcycle moto1 = new Motorcycle();
            moto1.Model = "XN-1293";
            moto1.Company = "Minsk";
            moto1.Distance = 90;
            Motorcycle.Engine forMoto1 = new Motorcycle.Engine();
            forMoto1.Volume = 126;
            forMoto1.Power = 50;

            //Moto 2
            Motorcycle moto2 = new Motorcycle();
            moto2.Model = "Suzuki-200";
            moto2.Company = "Suzuki";
            moto2.Distance = 0;
            Motorcycle.Engine forMoto2 = new Motorcycle.Engine();
            forMoto2.Volume = 3000;
            forMoto2.Power = 300;

            moto2.Discharge();

            //Moto 3
            Motorcycle moto3 = new Motorcycle();
            moto3.Model = "XRGT-290";
            moto3.Company = "Kavasaki";
            moto3.Distance = 20;
            Motorcycle.Engine forMoto3 = new Motorcycle.Engine();
            forMoto3.Volume = 3200;
            forMoto3.Power = 290;

            Motorcycle[] array = { moto1,  moto2,  moto3 };
            Motorcycle.Engine[] arrMoto = { forMoto1, forMoto2, forMoto3 };
            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine($"{i+1}. Motorcycle (Company): {array[i].Company}, Model: {array[i].Model}, Identificator: {array[i].Identificator}, Year: {array[i].Year}");
                Console.WriteLine($"{i+1}.1 Engine(Volume): {arrMoto[i].Volume}, Power: {arrMoto[i].Power}.");
            }            
        }
    }
}
