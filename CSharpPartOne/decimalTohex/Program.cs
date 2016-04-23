namespace decimalTohex
{
    using System;

    class Program
    {
        static void Main(string[] args)
        {
            long decimalNumbr = long.Parse(Console.ReadLine());
            string hexaNumber = string.Empty;

            if (decimalNumbr != 0)
            {
                while (decimalNumbr>0)
                {
                    var reminder = decimalNumbr%16;
                    switch (reminder)
                    {
                        case 10:
                            hexaNumber += "A";
                            break;
                        case 11:
                            hexaNumber += "B";
                            break;
                        case 12:
                            hexaNumber += "C";
                            break;
                        case 13:
                            hexaNumber += "D";
                            break;
                        case 14:
                            hexaNumber += "E";
                            break;
                        case 15:
                            hexaNumber += "F";
                            break;
                        default:
                            hexaNumber += reminder.ToString();
                            break;
                    }
                    decimalNumbr /= 16;

                }
                for (int i = hexaNumber.Length - 1; i >= 0; i--)
                {
                    Console.Write(hexaNumber[i]);

                }

            }
            else
            {
                Console.WriteLine(0);

            }
        }
    }
}
