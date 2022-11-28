using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuessTheNumber
{

    internal class RangeLimitsReader
    {
        private int rangeStart;
        private int rangeEnd;

        public RangeLimitsReader()
        {
            ReadLimits();
        }

        public int GetRangeStart()
        {
            return rangeStart;
        }

        public int GetRangeEnd() 
        { 
            return rangeEnd;
        }

        private void ReadLimits()
        {
            bool isRangeValid;
            do
            {
                isRangeValid = true;

                var rangeStartString = ReadValue("Inceputul intervalului:");

                var rangeEndString = ReadValue("Sfarsitul intervalului:");

                if (!int.TryParse(rangeStartString, out rangeStart)
                   || !int.TryParse(rangeEndString, out rangeEnd)
                   || !ValidateRangeLimitValues(rangeStart, rangeEnd))
                {
                    isRangeValid = false;
                    Console.WriteLine("Interval introdus gresit! Incearca din nou.");
                }
            } while (isRangeValid == false);
        }

        private static bool ValidateRangeLimitValues(int rangeStart, int rangeEnd)
        {
            return rangeStart <= rangeEnd;
        }

        private string ReadValue(string valueDescription)
        {
            Console.WriteLine(valueDescription);
            return Console.ReadLine();
        }

    }
}
