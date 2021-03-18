using System;
using Newtonsoft.Json;

namespace NPCLocator.a_big_mess
{
    class CraftingTable
    {
        public static void getFormula()
        {
            string json = System.IO.File.ReadAllText(@"C:\Users\XTigerHyperX\Desktop\New folder (4)\Output\JSONs\FortniteGame\Plugins\GameFeatures\PrimalGameplay\Content\DataTables\CraftingFormulas.json");
            var obj = JsonConvert.DeserializeObject<dynamic>(json);
            foreach (var item in obj)
            {
                Console.ForegroundColor = ConsoleColor.DarkCyan;
                Console.Write(item.ExportValue.BoneBowFormula.DisplayName.SourceString);
                foreach (var item2 in item.ExportValue.BoneBowFormula.RequiredIngredients)
                {
                    var a = item2.IngredientTags;
                    string b = a.ToString();
                    b=b.Replace("[", "");
                    b= b.Replace("]", "");
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.Write(" " + b);
                    Console.ForegroundColor = ConsoleColor.Magenta;
                    Console.Write("Count: ");
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine(item2.Count);
                }
                Console.Write("\n");
                Console.ForegroundColor = ConsoleColor.DarkCyan;
                Console.Write(item.ExportValue.MetalBowFormula.DisplayName.SourceString);
                foreach (var item2 in item.ExportValue.MetalBowFormula.RequiredIngredients)
                {
                    var a = item2.IngredientTags;
                    string b = a.ToString();
                    b = b.Replace("[", "");
                    b = b.Replace("]", "");
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.Write(" " + b);
                    Console.ForegroundColor = ConsoleColor.Magenta;
                    Console.Write("Count: ");
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine(item2.Count);
                }
                Console.Write("\n");

                Console.ForegroundColor = ConsoleColor.DarkCyan;
                Console.Write(item.ExportValue.FlameBowPepperFormula.DisplayName.SourceString);
                foreach (var item2 in item.ExportValue.FlameBowPepperFormula.RequiredIngredients)
                {
                    var a = item2.IngredientTags;
                    string b = a.ToString();
                    b = b.Replace("[", "");
                    b = b.Replace("]", "");
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.Write(" " + b);
                    Console.ForegroundColor = ConsoleColor.Magenta;
                    Console.Write("Count: ");
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine(item2.Count);
                }
                Console.Write("\n");
                Console.ForegroundColor = ConsoleColor.DarkCyan;
                Console.Write(item.ExportValue.FlameBowFireFliesFormula.DisplayName.SourceString);
                foreach (var item2 in item.ExportValue.FlameBowFireFliesFormula.RequiredIngredients)
                {
                    var a = item2.IngredientTags;
                    string b = a.ToString();
                    b = b.Replace("[", "");
                    b = b.Replace("]", "");
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.Write(" " + b);
                    Console.ForegroundColor = ConsoleColor.Magenta;
                    Console.Write("Count: ");
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine(item2.Count);
                }
                Console.Write("\n");

                Console.ForegroundColor = ConsoleColor.DarkCyan;
                Console.Write(item.ExportValue.FlameBowFlameFishFormula.DisplayName.SourceString);
                foreach (var item2 in item.ExportValue.FlameBowFlameFishFormula.RequiredIngredients)
                {
                    var a = item2.IngredientTags;
                    string b = a.ToString();
                    b = b.Replace("[", "");
                    b = b.Replace("]", "");
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.Write(" " + b);
                    Console.ForegroundColor = ConsoleColor.Magenta;
                    Console.Write("Count: ");
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine(item2.Count);
                }
                Console.Write("\n");

                Console.ForegroundColor = ConsoleColor.DarkCyan;
                Console.Write(item.ExportValue.FlameBowFlameGasCanFormula.DisplayName.SourceString);
                foreach (var item2 in item.ExportValue.FlameBowFlameGasCanFormula.RequiredIngredients)
                {
                    var a = item2.IngredientTags;
                    string b = a.ToString();
                    b = b.Replace("[", "");
                    b = b.Replace("]", "");
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.Write(" " + b);
                    Console.ForegroundColor = ConsoleColor.Magenta;
                    Console.Write("Count: ");
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.Write(item2.Count);
                }
                Console.Write("\n");

                Console.ForegroundColor = ConsoleColor.DarkCyan;
                Console.Write(item.ExportValue.StinkbombBowToxicSacFormula.DisplayName.SourceString);
                foreach (var item2 in item.ExportValue.StinkbombBowToxicSacFormula.RequiredIngredients)
                {
                    var a = item2.IngredientTags;
                    string b = a.ToString();
                    b = b.Replace("[", "");
                    b = b.Replace("]", "");
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.Write(" " + b);
                    Console.ForegroundColor = ConsoleColor.Magenta;
                    Console.Write("Count: ");
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.Write(item2.Count);
                }
                Console.Write("\n");

                Console.ForegroundColor = ConsoleColor.DarkCyan;
                Console.Write(item.ExportValue.StinkbombBowFlopperGasFormula.DisplayName.SourceString);
                foreach (var item2 in item.ExportValue.StinkbombBowFlopperGasFormula.RequiredIngredients)
                {
                    var a = item2.IngredientTags;
                    string b = a.ToString();
                    b = b.Replace("[", "");
                    b = b.Replace("]", "");
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.Write(" " + b);
                    Console.ForegroundColor = ConsoleColor.Magenta;
                    Console.Write("Count: ");
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.Write(item2.Count);
                }
                Console.Write("\n");

                Console.ForegroundColor = ConsoleColor.DarkCyan;
                Console.Write(item.ExportValue.ClusterbombBowFormula.DisplayName.SourceString);
                foreach (var item2 in item.ExportValue.ClusterbombBowFormula.RequiredIngredients)
                {
                    var a = item2.IngredientTags;
                    string b = a.ToString();
                    b = b.Replace("[", "");
                    b = b.Replace("]", "");
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.Write(" " + b);
                    Console.ForegroundColor = ConsoleColor.Magenta;
                    Console.Write("Count: ");
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.Write(item2.Count);
                }
                Console.Write("\n");

                Console.ForegroundColor = ConsoleColor.DarkCyan;
                Console.Write(item.ExportValue.FlameBowFlameGasCanFormula.DisplayName.SourceString);
                foreach (var item2 in item.ExportValue.FlameBowFlameGasCanFormula.RequiredIngredients)
                {
                    var a = item2.IngredientTags;
                    string b = a.ToString();
                    b = b.Replace("[", "");
                    b = b.Replace("]", "");
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.Write(" " + b);
                    Console.ForegroundColor = ConsoleColor.Magenta;
                    Console.Write("Count: ");
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.Write(item2.Count);
                }
                Console.Write("\n");

                Console.ForegroundColor = ConsoleColor.DarkCyan;
                Console.Write(item.ExportValue.ShockwaveFishBowFormula.DisplayName.SourceString);
                foreach (var item2 in item.ExportValue.ShockwaveFishBowFormula.RequiredIngredients)
                {
                    var a = item2.IngredientTags;
                    string b = a.ToString();
                    b = b.Replace("[", "");
                    b = b.Replace("]", "");
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.Write(" " + b);
                    Console.ForegroundColor = ConsoleColor.Magenta;
                    Console.Write("Count: ");
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.Write(item2.Count);
                }
                Console.Write("\n");

                Console.ForegroundColor = ConsoleColor.DarkCyan;
                Console.Write(item.ExportValue.ShockwaveBowFormula.DisplayName.SourceString);
                foreach (var item2 in item.ExportValue.ShockwaveBowFormula.RequiredIngredients)
                {
                    var a = item2.IngredientTags;
                    string b = a.ToString();
                    b = b.Replace("[", "");
                    b = b.Replace("]", "");
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.Write(" " + b);
                    Console.ForegroundColor = ConsoleColor.Magenta;
                    Console.Write("Count: ");
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.Write(item2.Count);
                }
                Console.Write("\n");

                Console.ForegroundColor = ConsoleColor.DarkCyan;
                Console.Write(item.ExportValue.ShockwaveFishBowFormula.DisplayName.SourceString);
                foreach (var item2 in item.ExportValue.ShockwaveFishBowFormula.RequiredIngredients)
                {
                    var a = item2.IngredientTags;
                    string b = a.ToString();
                    b = b.Replace("[", "");
                    b = b.Replace("]", "");
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.Write(" " + b);
                    Console.ForegroundColor = ConsoleColor.Magenta;
                    Console.Write("Count: ");
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.Write(item2.Count);
                }
                Console.Write("\n");
            }
        }
    }
}
