using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace BowlingGameTask
{
    public class Reader
    {
        public static string ReadFile(string fileName)
        {
            return File.ReadAllText(fileName);
        }

        public static List<int> GetPins(string list)
        {
            return list.Split(',').Select(Int32.Parse).ToList();
        }
    }
}

