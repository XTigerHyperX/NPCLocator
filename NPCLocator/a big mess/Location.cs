using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace NPCLocator.a_big_mess
{
    class Location
    {
        public static void Grab()
        {
            foreach (string file in Directory.EnumerateFiles(
                @"C:\Users\XTigerHyperX\Desktop\FModel-master\FModel\bin\x64\Debug\netcoreapp3.1\Output\JSONs\FortniteGame\Content\Quests\",
                "*.json"))
            {
                string json = System.IO.File.ReadAllText(file);
                json = json.Substring(1, json.Length - 2);
                var obj = JsonConvert.DeserializeObject<dynamic>(json);

                foreach (var item in obj.ExportValue.ChallengeMapPoiData)
                {
                    try
                    {
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.Write(item.LocationTag.TagName + " = ");

                        Console.ForegroundColor = ConsoleColor.Magenta;
                        Console.Write(item.Text.SourceString + "\n");
                        Console.ForegroundColor = ConsoleColor.White;
                        File.AppendAllText(@"C:\Users\XTigerHyperX\source\repos\NPCLocator\LocationData.txt",
                            item.LocationTag.TagName + " = " + item.Text.SourceString + "\n");
                    }
                    catch
                    {

                    }

                }

            }
        }
    }
}
