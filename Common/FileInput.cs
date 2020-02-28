using Application.Interfaces;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace Infrastructure
{
    public class FileInput : IInput
    {
        private readonly string filePath;
        private IEnumerable<string> values;

        public FileInput(string filePath)
        {
            this.filePath = filePath;
        }

        public IEnumerable<string> GetCommaSeparatedValues()
        {
            if (values == null)
            {
                StreamReader stream = new StreamReader(filePath);
                values = stream.ReadToEnd().Split(',', StringSplitOptions.RemoveEmptyEntries).Select(s => s.Trim());
                stream.Close();
            }
            return values;
        }

        public IEnumerable<string> GetLines()
        {
            StreamReader stream = new StreamReader(filePath);
            string line;
            while ((line = stream.ReadLine()) != null)
            {
                yield return line;
            }
            stream.Close();
        }
    }
}
