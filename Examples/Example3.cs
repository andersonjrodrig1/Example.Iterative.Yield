using Example.Interative.Yield.Entities;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;

namespace Example.Iterative.Yield.Examples
{
    public static class Example3
    {
        private static string PATH_ARCHIVE = @"./../../../Files/ARQUIVO.TEST2.20211211143000.txt";

        public static void ShowFruitList()
        {
            var stream = File.ReadAllText(PATH_ARCHIVE);

            var fruits = GetListFruits(new StringReader(stream));

            Console.WriteLine(JsonConvert.SerializeObject(fruits, Formatting.Indented));
        }

        private static IEnumerable<Fruit> GetListFruits(StringReader stringReader)
        {
            string line = string.Empty;

            while ((line = stringReader.ReadLine()) != null)
            {
                if (!string.IsNullOrEmpty(line) && !line.ToUpper().StartsWith("INIT") && !line.ToUpper().StartsWith("FINAL"))
                {
                    string[] split = line.Split(';');

                    var fruit = new Fruit
                    {
                        Id = Convert.ToInt32(split[0]),
                        Name = Convert.ToString(split[1]),
                        Amount = Convert.ToDouble(split[2]),
                        Price = Convert.ToDecimal(split[3])
                    };

                    yield return fruit;
                }
            }

            stringReader.Dispose();
        }
    }
}
