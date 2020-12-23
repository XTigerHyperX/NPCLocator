using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace NPCLocator.a_big_mess
{
    class DrawNPCOnMap
    {
        public static void draw()
        {
            string json = System.IO.File.ReadAllText(@"C:\Users\XTigerHyperX\source\repos\NPCLocator\YY.json");
            var obj = JsonConvert.DeserializeObject<dynamic>(json);
            string sNPC = "";
            string[] sLoc = null;
            Bitmap img =
                new Bitmap(@"C:\Users\XTigerHyperX\Desktop\New folder (4)\Output\Icons\Apollo_Terrain_Minimap.png");
            Graphics graphics = Graphics.FromImage(img);
            Bitmap bmp2 = new Bitmap(img);
            Bitmap resized = new Bitmap(bmp2, new Size(bmp2.Width * 2, bmp2.Height * 2));
            using (Image image = resized)
            using (Graphics imageGraphics = Graphics.FromImage(image))
            {
                foreach (var item in obj.POIS)
                {
                    bool skip = false;
                    sNPC = item.NPC;
                    string m = item.Tags[0];
                    try
                    {
                        float s = 900000000;
                        float ssl = 900000000;
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.Write("Successfully Drew ");
                        Console.ForegroundColor = ConsoleColor.Magenta;
                        Console.Write(item.NPC);
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.Write(" on map , location is : ");
                        Console.ForegroundColor = ConsoleColor.Cyan;
                        Console.Write(item.Tags[0] + "\n");
                        Console.ForegroundColor = ConsoleColor.White;


                        string json2 =
                            System.IO.File.ReadAllText(@"C:\Users\XTigerHyperX\source\repos\NPCLocator\newtest.json");
                        var obj2 = JsonConvert.DeserializeObject<dynamic>(json2);
                        foreach (var item2 in obj2.pois)
                        {
                            string j = item2.id;
                            if (j.ToUpper() == m.ToUpper())
                            {
                                s = item2.location.y;
                                ssl = item2.location.x;
                            }
                            else
                            {
                                continue;
                            }
                        }

                        var brush = Brushes.Black;
                        var fontD = new Font("Burbank Small Black", 27);
                        var fontDSetting = new Font(fontD, FontStyle.Bold);
                        var fontD2 = new Font("Burbank Small Black", 25);
                        var fontD2Setting = new Font(fontD2, FontStyle.Bold);
                        Graphics g = Graphics.FromImage(image);


                        float x = ((s + 135000) / (135000 * 2)) * 2048;
                        float y = (1 - (ssl + 135000) / (135000 * 2)) * 2048;


                        g.DrawString(sNPC, fontDSetting, brush, x - 50, y - 34);
                        g.DrawString(".", fontD2Setting, brush, x, y - 10);


                    }
                    catch
                    {
                        continue;
                    }
                }

                image.Save(@"C:\Users\XTigerHyperX\source\repos\NPCLocator\Hi2.png", ImageFormat.Png);

            }
        }
    }
}
    

