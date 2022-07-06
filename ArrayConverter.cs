using System;

namespace PokemonHGSSMoveEditor
{
    public static class ArrayConverter
    {
        public static int[] ByteToInt(byte[] byteArray)
        {
            int[] intArray = new int[byteArray.Length];

            for (int i = 0; i < byteArray.Length; i++)
            {
                intArray[i] = byteArray[i]
;           }

            return intArray;
        }

        public static byte[] IntToByte(int[] intArray)
        {
            byte[] byteArray = new byte[intArray.Length];

            for (int i = 0; i < intArray.Length; i++)
            {
                byteArray[i] = (byte)intArray[i];
            }

            return byteArray;
        }

        public static bool[] IndByteToBool(byte indByte)
        {
            //length is number of bits in a byte
            bool[] boolArray = new bool[8];

            //do a bitwise comparison on the byte and set each value in the bool array to true for each 1
            for(int i = 0; i < 8; i++)
            {
                boolArray[i] = Convert.ToBoolean(indByte & (int)Math.Pow(2, i));
            }

            return boolArray;
        }

        public static byte BoolToIndByte(bool[] boolArray)
        {
            byte indByte = 0;

            for (int i = 0; i < 8; i++)
            {
                if (boolArray[i])
                {
                    indByte += (byte)Math.Pow(2, i);
                }
            }

            return indByte;
        }
    }
}
