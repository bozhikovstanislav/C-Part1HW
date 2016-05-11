namespace FillTheMarix
{
    using System;
    class Program
    {
        static void Main(string[] args)
        {
          
            int n = int.Parse(Console.ReadLine()); //4   

            var letter = Console.ReadLine();
            int[,] multi = new int[n, n]; //4,4 {red, kolona}
            int ineer = 1;
            int ime = 1;
            int col = 0;
            int row = multi.GetLength(1) - ime;
            switch (letter)
            {
                case "a":
                    for (int i = 0; i < n; i++)
                    {
                        for (int z = 0; z < n; z++)
                        {
                            multi[i, z] = ineer;
                            ineer++;
                        }
                    }
                 
                    Print(multi);
                    break;
                case "b":
                    ineer = 1;
                    int count = 1;
                    for (int i = 0; i < n; i++)
                    {
                        if (count%2 != 0)
                        {
                            for (int z = 0; z < n; z++)
                            {
                                multi[i, z] = ineer;
                                ineer++;
                            }
                            count++;
                        }
                        else
                        {
                            for (int p = n - 1; p >= 0; p--)
                            {
                                multi[i, p] = ineer;
                                ineer++;
                            }
                            count++;
                        }
                    }
              
                    Print(multi);
                    Array.Clear(multi, 0, multi.Length);
                    break;

                case "c":
                    ineer = 1;  //  = 0
                   
                    int nameCol = 1;
                  
                    bool lastRow = true;
                    bool lastCol = false;

                    while (true)
                    {
                        if (lastRow)
                        {
                            row = multi.GetLength(1) - ime;
                            if (row < 0)
                            {
                                row = 0;
                                lastCol = true;
                            }

                        }
                        if (lastCol)
                        {
                            col = nameCol;
                        }
                        if (row == 0 && col == n - 1)
                        {
                            multi[n - 1, 0] = n * n;//ineer + 3 ;
                            break;
                        }
                        multi[col, row] = ineer;

                        ineer++;


                        if (row == n - 1)
                        {
                            ime++;
                            col = 0;
                            lastRow = true;
                            //ineer += 3;

                        }
                        else if (col == n - 1)
                        {
                            nameCol++;
                            row = 0;
                            lastCol = true; // to repair code.
                        }
                        else
                        {
                            row++;
                            col++;
                            lastRow = false;
                            lastCol = false; // new added 
                        }
                    }
         
                    Print(multi);
                    break;
                case "d":
                    ineer = 1;
                    row = 0;
                    col = 0;
                    int dokade = 0;
                    bool exit = false;
                    while (true)
                    {
                        for (int z = 0 + dokade; z < multi.GetLength(1) - dokade; z++)   // z < n - dokade
                        {
                            multi[col, z] = ineer;                    // |      /// array[ col , row ] ???
                            if (ineer == n * n)
                            {
                                exit = true;
                            }
                            ineer++;                                  // |
                            row = z;                                  // V
                        }
                        if (exit)
                        {
                            break;
                        }
                        for (int c = 1 + dokade; c < multi.GetLength(0) - dokade; c++)  /// ------->
                        {
                            multi[c, row] = ineer;
                            if (ineer == n * n)
                            {
                                exit = true;
                            }
                            ineer++;
                            col = c;
                        }
                        if (exit)
                        {
                            break;
                        }
                        for (int u = row - 1; u > -1 + dokade; u--)    // ^
                        {                                               // |
                            multi[col, u] = ineer;                      // |
                            if (ineer == n * n)
                            {
                                exit = true;
                            }
                            ineer++;                                    // |
                            row = u;                                    // |
                        }
                        if (exit)
                        {
                            break;
                        }
                        dokade++;
                        for (int le = col - 1; le > -1 + dokade; le--)     /// <-------   //// col - 1 - dokade
                        {
                            multi[le, row] = ineer;
                            if (ineer == n * n)
                            {
                                exit = true;
                            }
                            ineer++;
                            col = le;
                        }
                        if (exit)
                        {
                            break;
                        }
                    }

                    Print(multi);
                    break;
            }

  
        }
        static void Print(int[,] array)
        {
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int z = 0; z < array.GetLength(1); z++)
                {
                    Console.Write("{0,3}", array[z, i]);
                }
                Console.WriteLine();
            }
        }
    }
}
