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
            Bitmap img = new Bitmap(@"C:\Users\XTigerHyperX\Desktop\New folder (4)\Output\Icons\Apollo_Terrain_Minimap.png");
            Graphics graphics = Graphics.FromImage(img);
            Bitmap bmp2 = new Bitmap(img);
            Bitmap resized = new Bitmap(bmp2, new Size(bmp2.Width * 2 , bmp2.Height * 2 ));
            using (Image image = resized)
            using (Graphics imageGraphics = Graphics.FromImage(image))
            {
                foreach (var item in obj.POIS)
                {
                    bool skip = false;
                    sNPC = item.NPC;
                    string m = item.Tags[0];
                    string m2 = "";
                    string m3 = "";
                    try
                    {
                        m2 = item.Tags[1];
                        m3 = item.Tags[2];
                    }
                    catch{}
                    try
                    {
                        float s = 900000000;
                        float ssl = 900000000;
                        Console.WriteLine(item.NPC);
                        Console.WriteLine(item.Tags[0]);
                        string json2 = System.IO.File.ReadAllText(@"C:\Users\XTigerHyperX\source\repos\NPCLocator\newtest.json");
                        var obj2 = JsonConvert.DeserializeObject<dynamic>(json2);
                        foreach (var item2 in obj2.pois)
                        {
                            string j = item2.id;
                            if (j.ToUpper() == m.ToUpper() || j.ToUpper() == m2.ToUpper() || j.ToUpper() == m3.ToUpper())
                            {
                                string sx = j;
                                var brush = Brushes.Black;
                                var fontD = new Font("Burbank Small Black", 27);
                                var fontDSetting = new Font(fontD, FontStyle.Bold);
                                var fontD2 = new Font("Burbank Small Black", 25);
                                var fontD2Setting = new Font(fontD2, FontStyle.Bold);


                                s = item2.location.y;
                                ssl = item2.location.x;
                                Graphics g = Graphics.FromImage(image);
                                float x = ((s + 135000) / (135000 * 2)) * 2048;
                                float y = (1 - (ssl + 135000) / (135000 * 2)) * 2048;
                                if (item.NPC == "Blaze" || item.NPC == "Brutus" || item.NPC == "Menace" || item.NPC == "Ragnarok" || item.NPC == "Big Chuggus" || item.NPC == "Ruckus" || item.NPC == "Kondor" || item.NPC == "Kit")
                                {
                                    g.DrawString(sNPC, fontDSetting, brush, x - 50, y - 34);
                                    g.DrawString(".", fontD2Setting, brush, x, y - 10);
                                    Console.ForegroundColor = ConsoleColor.Green;
                                    Console.Write("Successfully Drew ");
                                    Console.ForegroundColor = ConsoleColor.Magenta;
                                    Console.Write(item.NPC);
                                    Console.ForegroundColor = ConsoleColor.White;
                                    Console.Write(" on map , location is : ");
                                    Console.ForegroundColor = ConsoleColor.Cyan;
                                    Console.Write(sx + "\n");
                                    Console.ForegroundColor = ConsoleColor.White;
                                }
                                else
                                {
                                    Console.ForegroundColor = ConsoleColor.Red;
                                    Console.WriteLine("Ignored");
                                    Console.ForegroundColor = ConsoleColor.White;
                                    continue;
                                }

                            }
                            else
                            {
                                continue;
                            }
                        }
                      
                    }
                    catch
                    {
                        continue;
                    }
                }
                image.Save(@"C:\Users\XTigerHyperX\source\repos\NPCLocator\generated maps\Hi2.png", ImageFormat.Png);
                
            }
        }
    }
}
    

