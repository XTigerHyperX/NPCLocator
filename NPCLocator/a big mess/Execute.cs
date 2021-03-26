using System;
using System.Collections.Generic;
using System.IO;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;


namespace NPCLocator.a_big_mess
{
    class Execute
    {
        public static void ExportAndRead()
        {
            var watch = new System.Diagnostics.Stopwatch();
            File.WriteAllText(@"C:\Users\XTigerHyperX\source\repos\NPCLocator\TandemData.txt", "");
            File.WriteAllText(@"C:\Users\XTigerHyperX\source\repos\NPCLocator\YY.json", "{" + "\n" + "\"POIS\": [" + "\n");
            string kk ="";
            List<string> AllFiles = new List<string>();
            void ParsePath(string path)
            {
                string[] SubDirs = Directory.GetDirectories(path);
                AllFiles.AddRange(SubDirs);
                AllFiles.AddRange(Directory.GetFiles(path));
                foreach (string subdir in SubDirs)
                {
                    string sub = subdir;
                    sub = sub.Substring(sub.LastIndexOf("\\", sub.Length));sub = sub.Substring(1);
                    DirectoryInfo taskDirectory = new DirectoryInfo(subdir);
                    FileInfo[] filesInDir = taskDirectory.GetFiles("NPCCharacterData_" + sub + "*.json*");
                    foreach (FileInfo NPCJson  in filesInDir)
                    {
                        string fullName = NPCJson.FullName;
                        Console.ForegroundColor = ConsoleColor.White;
                        try
                        {
                            string json = File.ReadAllText(fullName);
                            json = json.Substring(1, json.Length - 2);
                            var obj = JsonConvert.DeserializeObject<dynamic>(json);
                            dynamic product = new JObject();
                            product.NPC = obj.ExportValue.DisplayName.SourceString;
                            product.Tags = new JArray(obj.ExportValue.POILocations);
                            kk = kk + product.ToString() + "," + "\n";
                            File.AppendAllText(@"C:\Users\XTigerHyperX\source\repos\NPCLocator\TandemData.txt", "NPC : " + obj.ExportValue.DisplayName.SourceString + "\n" + obj.ExportValue.POILocations);

                        }
                        catch
                        {

                        }
                        Console.WriteLine(fullName);
                    }
                    ParsePath(subdir);
                }
            }
            ParsePath(@"C:\Users\XTigerHyperX\Desktop\New folder (4)\Output\JSONs\FortniteGame\Plugins\GameFeatures\NPCLibrary\Content\NPCs");

            int index = kk.LastIndexOf(',');
            kk = kk.Remove(index, 1);
            File.AppendAllText(@"C:\Users\XTigerHyperX\source\repos\NPCLocator\YY.json", kk + "] \n }");

        }
    }
}
