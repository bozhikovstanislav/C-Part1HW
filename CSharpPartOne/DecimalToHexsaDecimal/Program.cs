namespace DecimalToHexsaDecimal
{
    using System;
    class Program
    {
        static void Main(string[] args)
        {
            string hexaNumber = Console.ReadLine();
            int count = hexaNumber.Length - 1;
            long decimalNumber = 0;
            int factor = 0;

            for (int i = 0; i < hexaNumber.Length; i++)
            {
                switch (hexaNumber[i])
                {
                    case 'A':
                        factor = 10;
                        break;
                    case 'B':
                        factor = 11;
                        break;
                    case 'C':
                        factor = 12;
                        break;
                    case 'D':
                        factor = 13;
                        break;
                    case 'E':
                        factor = 14;
                        break;
                    case 'F':
                        factor = 15;
                        break;
                    default:
                        factor = int.Parse(hexaNumber[i].ToString());
                        break;
                }

                decimalNumber += factor * (long)Math.Pow(16, (count - i));
            }

            Console.WriteLine(decimalNumber);
        }
    }
}
