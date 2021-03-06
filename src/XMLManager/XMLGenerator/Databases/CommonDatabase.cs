﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XMLGenerator.Databases
{
    public class CommonDatabase
    {
        public static int GetRandomAvailable()
        {
            return Generator.random.Next(10);
        }

        public static string GetRandomPrice()
        {
            return Generator.random.Next(100, 801) + "лева";
        }

        public static T GetRandomFromCollection<T>(IEnumerable<T> collection)
        {
            return collection.ElementAt(Generator.random.Next(0, collection.Count()));
        }
    }
}
