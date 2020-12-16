using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Newtonsoft;
using Newtonsoft.Json;


namespace NPCLocator.a_big_mess
{
    class Execute
    {
        public static void ExportAndRead()
        {
            var watch = new System.Diagnostics.Stopwatch();

            watch.Start();
            foreach (string file in Directory.EnumerateFiles(@"C:\Users\XTigerHyperX\Desktop\New folder (4)\Output\JSONs\FortniteGame\Plugins\GameFeatures\BattlepassS15\Content\Items\NpcItems\", "*.json"))
            {
                Console.ForegroundColor = ConsoleColor.White;
                try
                {
                    string json = System.IO.File.ReadAllText(file);
                    json = json.Substring(1, json.Length - 2);
                    var obj = JsonConvert.DeserializeObject<dynamic>(json);
                    Console.Write("NPC : ");
                    Console.ForegroundColor = ConsoleColor.Magenta;
                    Console.WriteLine(obj.ExportValue.DisplayName.SourceString);
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine(obj.ExportValue.POILocations);
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.WriteLine("Dialogue : " + obj.ExportValue.AdditionalDescription.SourceString);
                }
                catch
                {

                }

            }
            watch.Stop();
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine($"Execution Time: {watch.ElapsedMilliseconds} ms");
            Console.ForegroundColor = ConsoleColor.White;
        }
    }
}
