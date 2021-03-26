using System;
using System.Drawing;
using System.Drawing.Imaging;
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
                string json = System.IO.File.ReadAllText(@"C:\Users\XTigerHyperX\Desktop\New folder (4)\Output\JSONs\FortniteGame\Content\Quests\QuestIndicatorData.json");
                json = json.Substring(1, json.Length - 2);
                var obj = JsonConvert.DeserializeObject<dynamic>(json);
                var brush2 = Brushes.White;
                var fontD = new Font("Burbank Small Black", 20);
                var fontDSetting = new Font(fontD, FontStyle.Bold);
                var fontD2 = new Font("Burbank Small Black", 30);
                var fontD2Setting = new Font(fontD2, FontStyle.Bold);
                Graphics g = Graphics.FromImage(image);
                int fortniteWorldDimensions = 135000;

                foreach (var item in obj.ExportValue.ChallengeMapPoiData)
                {
                    try
                    {
                        var brush = Brushes.White;
                        float s = item.WorldLocation.Y;
                        float ssl = item.WorldLocation.X;
                        float x = ((s + fortniteWorldDimensions) / (fortniteWorldDimensions * 2)) * 2048;
                        float y = (1 - (ssl + fortniteWorldDimensions) / (fortniteWorldDimensions * 2)) * 2048;
                        string sr = item.Text.SourceString;
                        string sr2 = item.LocationTag.TagName;
                        if (!sr2.ToUpper().Contains("PAPAYA")) // <-- t
                        {
                            int ys = 24;
                            int ypoint = 10;
                            if (sr.ToUpper() == "ZERO POINT" || sr.ToUpper() == "STEALTHY STRONGHOLD")
                            {
                                ys = 70;
                                ypoint = 60;
                            }
                            else if (sr.ToUpper() == "Guardian of the Sea".ToUpper())
                            {
                                ys = 50;
                                ypoint = 30;
                            }
                            else if (sr.ToUpper() == "MOUNT KAY" || sr.ToUpper() == "LAZY LAKE ISLAND" || sr.ToUpper() == "BASE CAMP GOLF" || sr.ToUpper() == "FLUSHED FACTORY")
                            {
                                ys = 40;
                                ypoint = 30;
                            }
                            if (sr2.ToUpper().Contains("UnnamedPOI".ToUpper()))
                                brush = Brushes.Black;
                            g.DrawString(sr, fontDSetting, brush, x - 50, y - ys);
                            g.DrawString(".", fontD2Setting, brush, x, y - ypoint);
                        }
                        else
                        {
                            continue;
                        }
                    }
                    catch { }
                }
                image.Save(@"C:\Users\XTigerHyperX\source\repos\NPCLocator\generated maps\Hi.png", ImageFormat.Png);

            }
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Finished!");
            Console.ForegroundColor = ConsoleColor.White;

        }
    }
}