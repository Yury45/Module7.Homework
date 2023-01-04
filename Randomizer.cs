using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module7.Homework
{
    internal static class Randomizer
    {
        private static Random random = new Random();

        internal static bool GetRandomBool()
        {
            bool value;

            value = random.Next(100) <= 50 ? true : false;

            return value;
        }

        internal static int GetRandomNumber()
        {
            int value = random.Next(235_431, 3_345_445);
            return value;
        }

    }
}
