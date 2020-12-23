using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace NPCLocator.a_big_mess
{
    class POINameTranslator
    {
        public static void Translate()
        {
            var locations = File.ReadAllLines(@"C:\Users\XTigerHyperX\source\repos\NPCLocator\LocationData.txt");
            var tandem = File.ReadAllText(@"C:\Users\XTigerHyperX\source\repos\NPCLocator\TandemData.txt");
            tandem = tandem.Replace(".Tandem", "");
            var map = locations.ToDictionary(line => line.Split('=')[0].Trim(), line => line.Split('=')[1].Trim());

            foreach (var yeet in map)
            {
                //Console.WriteLine(yeet.Value);
                tandem = tandem.Replace(yeet.Key, yeet.Value);
            }
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("Translated all location codenames");
            Console.ForegroundColor = ConsoleColor.White;


            File.AppendAllText(@"C:\Users\XTigerHyperX\source\repos\NPCLocator\Final.txt", tandem);

        }
    }
}
