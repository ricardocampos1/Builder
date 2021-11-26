using System;
using System.Collections.Generic;

namespace Carmaker.Products
{
    public class Vehicle
    {
        public string Model { get; set; }
        public string Engine { get; set; }
        public string Transmission { get; set; }
        public string Body { get; set; }
        public List<string> Accessories { get; set; }

        public Vehicle()
        {
            Accessories = new List<string>();
        }

        public void ShowInfo()
        {
            Console.WriteLine("Modelo: {0}", Model);
            Console.WriteLine("Motor: {0}", Engine);
            Console.WriteLine("Carroçaria: {0}", Body);
            Console.WriteLine("Transmissão: {0}", Transmission);
            Console.WriteLine("Acessórios:");
            foreach (var accessory in Accessories)
            {
                Console.WriteLine("\t{0}", accessory);
            }
        }
    }
}
