using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic
{
    public static class PermutedMultiples
    {
        private const uint maxThreshold = ((uint)int.MaxValue) + 1;

        public static uint MaxThreshold
        {
            get { return maxThreshold; }
        }

        public static bool IsMatching(uint value)
        {
            bool result = false;

            if (value > MaxThreshold)
            {
                throw new OverflowException(String.Format("The value supplied is out of the acceptable max range of: {0}", Int32.MaxValue));
            }
            else if (value == 0)
            {
                throw new IndexOutOfRangeException("The value supplied is not within the acceptable index range");
            }

            try
            {
                Char[] doubledArray = (value*2).ToString(CultureInfo.InvariantCulture).ToCharArray();
                Char[] valuesArray = value.ToString(CultureInfo.InvariantCulture).ToCharArray();

                Array.Sort(doubledArray);
                Array.Sort(valuesArray);

                result = (doubledArray.SequenceEqual(valuesArray) && doubledArray.Length == valuesArray.Length);
            }
            catch (Exception ex)
            {
                throw new Exception("There was an exception.");
            }

            return result;
        }
    }
}
