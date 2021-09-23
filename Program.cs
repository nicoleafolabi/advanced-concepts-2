using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;
namespace advanced_concepts_2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Pulled info from json file
            var gjson = File.ReadAllText("./generic.json");
            var generics = JsonSerializer.Deserialize<List<Generic>>(gjson);
            // created dictionary
            var fnDict = new Dictionary<string, Func<int, int, int>>(){
            {"sum", (a, b) => a + b},
            {"product", (a, b) => a * b},
            {"difference", (a,b) => a-b},
           };

            Console.WriteLine("Which function would you like to perform?");
            var function = Console.ReadLine();

            Console.WriteLine("Select which coloumn of numbers you would like your input from. A, B, or C");
            var coloumn1 = Console.ReadLine();

            Console.WriteLine("Select another coloumn of numbers you would like your input from. A, B, or C");
            var coloumn2 = Console.ReadLine();
            var results = 0;

            foreach (var generic in generics)
            {
                if (coloumn1 == "A")
                {
                    if (coloumn2 == "A")
                    {
                        results = fnDict[function](generic.A, generic.A);
                    }
                    if (coloumn2 == "B")
                    {
                        results = fnDict[function](generic.A, generic.B);
                    }
                    if (coloumn2 == "C")
                    {
                        results = fnDict[function](generic.A, generic.C);
                    }
                }
                else if (coloumn1 == "B")
                {
                    if (coloumn2 == "A")
                    {
                        results = fnDict[function](generic.B, generic.A);
                    }
                    if (coloumn2 == "B")
                    {
                        results = fnDict[function](generic.B, generic.B);
                    }
                    if (coloumn2 == "C")
                    {
                        results = fnDict[function](generic.B, generic.C);
                    }
                }
                else if (coloumn1 == "C")
                {
                    if (coloumn2 == "A")
                    {
                        results = fnDict[function](generic.C, generic.A);
                    }
                    if (coloumn2 == "B")
                    {
                        results = fnDict[function](generic.C, generic.B);
                    }
                    if (coloumn2 == "C")
                    {
                        results = fnDict[function](generic.C, generic.C);
                    }
                }
                Console.WriteLine(results);

            }
        }
    }
}
