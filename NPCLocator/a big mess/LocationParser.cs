using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Net.Mime;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace NPCLocator.a_big_mess
{
    class LocationParser
    {
        public static void DrawOnMap()
        {
            Console.ForegroundColor = ConsoleColor.Red;

            Console.WriteLine("Drawing Image ...");
            Bitmap img = new Bitmap(@"C:\Users\XTigerHyperX\Desktop\New folder (4)\Output\Icons\Apollo_Terrain_Minimap.png");
            Graphics graphics = Graphics.FromImage(img);
            Bitmap bmp2 = new Bitmap(img);
            Bitmap resized = new Bitmap(bmp2, new Size(bmp2.Width * 2, bmp2.Height * 2));
            using (Image image = resized)
            using (Graphics imageGraphics = Graphics.FromImage(image))
            {
                foreach (string file in Directory.EnumerateFiles(
                    @"C:\Users\XTigerHyperX\Desktop\FModel-master\FModel\bin\x64\Debug\netcoreapp3.1\Output\JSONs\FortniteGame\Content\Quests\",
                    "*.json"))
                {
                    string json = System.IO.File.ReadAllText(file);
                    json = json.Substring(1, json.Length - 2);
                    var obj = JsonConvert.DeserializeObject<dynamic>(json);
                    var brush = Brushes.Black;
                    var fontD = new Font("Burbank Small Black", 20);
                    var fontDSetting = new Font(fontD, FontStyle.Bold);
                    var fontD2 = new Font("Burbank Small Black", 23);
                    var fontD2Setting = new Font(fontD2, FontStyle.Bold);
                    Graphics g = Graphics.FromImage(image);


                    foreach (var item in obj.ExportValue.ChallengeMapPoiData)
                    {
                        try
                        {
                            float s = item.WorldLocation.Y;
                            float ssl = item.WorldLocation.X;
                            float x = ((s + 135000) / (135000 * 2)) * 2048;
                            float y = (1 - (ssl + 135000) / (135000 * 2)) * 2048;

                            string sr = item.Text.SourceString;
                            string sr2 = item.LocationTag.TagName;
                            if (!sr2.ToUpper().Contains("PAPAYA")) // <-- t
                            {
                                g.DrawString(sr, fontDSetting, brush, x - 50, y - 24);
                                g.DrawString(".", fontD2Setting, brush, x, y - 10);
                            }
                            else
                            {
                                continue;
                            }
                        }
                        catch
                        {

                        }

                    }

                    image.Save(@"C:\Users\XTigerHyperX\source\repos\NPCLocator\Hi.png", ImageFormat.Png);
                }
            }
            Console.ForegroundColor = ConsoleColor.Green;

            Console.WriteLine("Finished!");
            Console.ForegroundColor = ConsoleColor.White;

        }
    }
}
