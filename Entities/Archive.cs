using System.Collections.Generic;
using System.IO;

namespace Example.Interative.Yield.Entities
{
    public class Archive
    {
        private StringReader _stringReader;
        private string _nameArchive;

        public Archive(StringReader stringReader, string nameArchive)
        {
            _stringReader = stringReader;
            _nameArchive = nameArchive;
        }

        public string NameArchive { get => _nameArchive; }

        public int AmountLine { get; private set; }

        public IEnumerable<Detail> Details 
        { 
            get 
            {
                string line = string.Empty;
                int count = 0;

                while ((line = _stringReader.ReadLine()) != null)
                {
                    if (!string.IsNullOrEmpty(line) && !line.ToUpper().StartsWith("INIT") && !line.ToUpper().StartsWith("FIN"))
                    {
                        count++;

                        var detail = new Detail
                        {
                            NumberLine = count,
                            Content = line
                        };

                        yield return detail;
                    }
                }

                this.AmountLine = count;

                _stringReader.Dispose();
            } 
        }
    }
}
