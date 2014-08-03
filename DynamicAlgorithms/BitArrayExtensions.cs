using System.Collections;

namespace DynamicAlgorithms
{
    public static class BitArrayExtensions
    {
        public static int ToInteger(this BitArray bits)
        {
            var number = new int[1];
            bits.CopyTo(number, 0);
            var numberValue = number[0];
            return numberValue;
        }
    }
}