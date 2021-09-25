using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BadSuperbowlNamer
{
    public class NumberTranslator
    {
        public string Translate(int numberToTranslate)
        {
            StringBuilder returnStr = new StringBuilder();
            int baseValue = GetBaseValue(numberToTranslate);
            int quotient = numberToTranslate / baseValue;
            int remainder = numberToTranslate % baseValue;

            string symbol = GetSymbol(baseValue);

            for (int i = quotient; i > 0; i--)
            {
                returnStr.Append(symbol);
            }

            if ( remainder > 0)
            {
                returnStr.Append(Translate(remainder));
            }
            return returnStr.ToString();

        }
        public int GetBaseValue(int number)
        {
            int returnVal = 0;
            int[] baseValues = new int[] {
                1000,
                900,
                500,
                400,
                100,
                90,
                50,
                40,
                10,
                9,
                5,
                4,
                1 };

            foreach (int value in baseValues)
            {
                if (number >= value)
                {
                    returnVal = value;
                    break;
                }
            }
            return returnVal;
        }

        public string GetSymbol(int baseValue)
        {
            StringBuilder returnStr = new StringBuilder();
            switch (baseValue)
            {
                case 1000:
                    returnStr.Append('M');
                    break;
                case 900:
                    returnStr.Append("CM");
                    break;
                case 500:
                    returnStr.Append('D');
                    break;
                case 400:
                    returnStr.Append("CD");
                    break;
                case 100:
                    returnStr.Append('C');
                    break;
                case 90:
                    returnStr.Append("XC");
                    break;
                case 50:
                    returnStr.Append('L');
                    break;
                case 40:
                    returnStr.Append("XL");
                    break;
                case 10:
                    returnStr.Append('X');
                    break;
                case 9:
                    returnStr.Append("IX");
                    break;
                case 5:
                    returnStr.Append('V');
                    break;
                case 4:
                    returnStr.Append("IV");
                    break;
                case 1:
                    returnStr.Append('I');
                    break;
                default:
                    break;
            }
            return returnStr.ToString();
        }
    }
}
