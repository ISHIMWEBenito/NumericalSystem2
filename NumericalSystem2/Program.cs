using System;

namespace NumericalSystems
{
    class Calculate
    {
        public string ToBinary(int num)
        {

            string result = "";
            int i;
            int j;
            int[] remainder = new int[10];
            for (i = 0; num > 0; i++)
            {
                remainder[i] = num % 2;
                num = num / 2;
            }
            for (j = i - 1; j >= 0; j--)
            {
                result = result + remainder[j];
            }
            return result;



        }
        public string ToOctal(int num1)
        {
            int decValue, counter, i = 1, j;
            int[] OctalValue = new int[80];
            string answer = "";
            
            decValue = num1;
            counter = decValue;
            while (counter != 0)
            {
                OctalValue[i++] = counter % 8;
                counter /= 8;
            }
            for (j = i - 1; j > 0; j--)
            {
                answer = answer + OctalValue[j];
            }
            return answer;
        }

        public string ToHex(int num2)
        {
            string result = "";

            while (num2 != 0)
            {
                if ((num2 % 16) < 10)
                    result = num2 % 16 + result;
                else
                {
                    string temp = "";
                    switch (num2 % 16)
                    {
                        case 10: temp = "A"; break;
                        case 11: temp = "B"; break;
                        case 12: temp = "C"; break;
                        case 13: temp = "D"; break;
                        case 14: temp = "E"; break;
                        case 15: temp = "F"; break;
                    }
                    result = temp + result;
                }
                num2 /= 16;
            }
            return result;
        }



        static void Main(string[] args)
        {

            //string ret = " ";
            Console.WriteLine("Type a number:");
            int number = int.Parse(Console.ReadLine());
            Calculate cal = new Calculate();
            //ret = cal.ToBinary(number);
            Console.WriteLine("In decimal: {0}", number);
            Console.WriteLine("In binary: {0}", cal.ToBinary(number));
            Console.WriteLine("In octal: {0}", cal.ToOctal(number));
            Console.WriteLine("In hex: {0}", cal.ToHex(number));

        }
    }

}
/*
 public static int HexToDec(string x)
    {
        int result = 0;
        int count = x.Length - 1;
        for (int i = 0; i < x.Length; i++)
        {
            int temp = 0;
            switch (x[i])
            {
                case 'A': temp = 10; break;
                case 'B': temp = 11; break;
                case 'C': temp = 12; break;
                case 'D': temp = 13; break;
                case 'E': temp = 14; break;
                case 'F': temp = 15; break;
                default: temp = -48 + (int)x[i]; break; // -48 because of ASCII
            }

            result += temp * (int)(Math.Pow(16, count));
            count--;
        }

        return result;
    }
 */