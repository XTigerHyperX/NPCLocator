using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Newtonsoft;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;


namespace NPCLocator.a_big_mess
{
    class Execute
    {
        public static void ExportAndRead()
        {
            var watch = new System.Diagnostics.Stopwatch();

            watch.Start();
            File.WriteAllText(@"C:\Users\XTigerHyperX\source\repos\NPCLocator\TandemData.txt", "");
            File.WriteAllText(@"C:\Users\XTigerHyperX\source\repos\NPCLocator\YY.json", "{"+ "\n" + "\"POIS\": [" +"\n");
            string kk ="";
            foreach (string file in Directory.EnumerateFiles(@"C:\Users\XTigerHyperX\Desktop\New folder (4)\Output\JSONs\FortniteGame\Plugins\GameFeatures\BattlepassS15\Content\Items\NpcItems\", "*.json"))
            {
                int counter = 0;
                string line;
                Console.ForegroundColor = ConsoleColor.White;
                try
                {
                    string json = System.IO.File.ReadAllText(file);
                    json = json.Substring(1, json.Length - 2);
                    var obj = JsonConvert.DeserializeObject<dynamic>(json);
                    string Ss, PL, ADSS;

                    dynamic product = new JObject();
                    product.NPC = obj.ExportValue.DisplayName.SourceString;
                    product.Tags = new JArray(obj.ExportValue.POILocations);
                    kk = kk + product.ToString() + "," + "\n";
                    File.AppendAllText(@"C:\Users\XTigerHyperX\source\repos\NPCLocator\TandemData.txt", "NPC : " + obj.ExportValue.DisplayName.SourceString +"\n" + obj.ExportValue.POILocations);

                }
                catch
                {

                }

            }
            int index = kk.LastIndexOf(',');
            kk = kk.Remove(index, 1);
            File.AppendAllText(@"C:\Users\XTigerHyperX\source\repos\NPCLocator\YY.json",kk + "] \n }");


            watch.Stop();
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine($"Execution Time: {watch.ElapsedMilliseconds} ms");
            Console.ForegroundColor = ConsoleColor.White;
        }
    }
}
