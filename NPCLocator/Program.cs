using System;
using NPCLocator.a_big_mess;

namespace NPCLocator
{
    class Program
    {
        static void Main(string[] args)
        {
            a_big_mess.Execute.ExportAndRead();
            POINameTranslator.Translate();
            LocationParser.DrawOnMap();
            DrawNPCOnMap.draw();
            Console.ReadKey();
        }
    }
    
}
