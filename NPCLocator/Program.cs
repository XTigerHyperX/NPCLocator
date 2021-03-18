using System;
using System.Drawing;
using System.Linq;
using NPCLocator.a_big_mess;

namespace NPCLocator
{
    class Program
    {
        static void Main(string[] args)
        {
            Location.Grab();
            //a_big_mess.Execute.ExportAndRead();
            POINameTranslator.Translate();
            LocationParser.DrawOnMap();
            //DrawNPCOnMap.draw();
            CraftingTable.getFormula();
            Console.ReadKey();
        }
    }
}
