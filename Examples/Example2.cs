using Example.Interative.Yield.Entities;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.IO;

namespace Example.Iterative.Yield.Examples
{
    public static class Example2
    {
        private static string PATH_ARCHIVE = @"./../../../Files/ARQUIVO.TEST1.20211211143000.txt";

        public static void ShowDataArchive()
        {
            var stringReader = File.ReadAllText(PATH_ARCHIVE);

            var archive = new Archive(new StringReader(stringReader), "Arquivo de Teste");

            var details = GetArchiveComplete(archive);

            System.Console.WriteLine(JsonConvert.SerializeObject(details, Formatting.Indented));
        }

        private static IEnumerable<Detail> GetArchiveComplete(Archive archive)
        {
            foreach (var detail in archive.Details)
                yield return detail;
        }
    }
}
