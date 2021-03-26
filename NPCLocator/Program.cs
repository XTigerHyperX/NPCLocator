using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using NPCLocator.a_big_mess;

namespace NPCLocator
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Location.Grab();
            Execute.ExportAndRead();
            POINameTranslator.Translate();
            LocationParser.DrawOnMap();
            DrawNPCOnMap.draw();
            //CraftingTable.getFormula();
            Console.ReadKey();
        }
    }
}
