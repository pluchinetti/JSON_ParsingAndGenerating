﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//include
using System.IO;
using Newtonsoft.Json;

using Library;

namespace Program
{
    class Program
    {
        static void Main(string[] args)
        {
            List<CompactCar> garage = InitializeGarage();

            Console.WriteLine("Cantidad de vehículos: " + garage.Count);

            Console.WriteLine("Marca: {0} | Modelo: {1} | Año: {2} | Seats: {3}", garage[0].Make , garage[0].Model, garage[0].Year, garage[0].Seats);
            Console.WriteLine("Doors: {0} | Aprobación NCAP: {1}", garage[0].Doors , garage[0].NCAPCompliant);
        
            string outputJSON = JsonConvert.SerializeObject(garage);
            File.WriteAllText("Output.json", outputJSON);
        }

        public static List<CompactCar> InitializeGarage()
        {
            List<CompactCar> garage = new List<CompactCar>();

            CompactCar a1 = new CompactCar();
            a1.Make = "Audi";
            a1.Model = "A1";
            a1.Year = 2018;
            a1.Doors = 2;
            a1.NCAPCompliant = true;
            a1.Seats = 4;
            a1.Features.Add(new Feature("ISOFIX",true));
            a1.Features.Add(new Feature("ABS",true));
            a1.Features.Add(new Feature("Laser Headlights",false));
            a1.Features.Add(new Feature("LED DRL",true));
            a1.Features.Add(new Feature("Assisted Driving",true));
            garage.Add(a1);

            CompactCar bal = new CompactCar();
            bal.Make = "Suzuki";
            bal.Model = "Baleno";
            bal.Year = 2018;
            bal.Doors = 4;
            bal.NCAPCompliant = true;
            bal.Seats = 4;
            bal.Features.Add(new Feature("ISOFIX",true));
            bal.Features.Add(new Feature("ABS",true));
            bal.Features.Add(new Feature("Laser Headlights",false));
            bal.Features.Add(new Feature("LED DRL",true));
            bal.Features.Add(new Feature("Assisted Driving",false));
            garage.Add(bal);

            CompactCar up = new CompactCar();
            up.Make = "Volkswagen";
            up.Model = "Up";
            up.Year = 2016;
            up.Doors = 4;
            up.NCAPCompliant = true;
            up.Seats = 4;
            up.Features.Add(new Feature("ISOFIX",true));
            up.Features.Add(new Feature("ABS",true));
            up.Features.Add(new Feature("Laser Headlights",false));
            up.Features.Add(new Feature("LED DRL",false));
            up.Features.Add(new Feature("Assisted Driving",false));
            garage.Add(up);

/*             SportsCar r8 = new SportsCar();
            r8.Make = "Audi";
            r8.Model = "R8";
            r8.Year = 2014;
            r8.Seats = 2;
            r8.HP = 493;
            r8.LaunchControl = false;
            r8.Turbo = true;
            r8.Features.Add(new Feature("Laser Headlights",false));
            r8.Features.Add(new Feature("LED DRL",true));
            r8.Features.Add(new Feature("Assisted Driving",false));
            r8.Features.Add(new Feature("Hard Roof",true));
            garage.Add(r8); */



            return garage;
        }
    }
}
