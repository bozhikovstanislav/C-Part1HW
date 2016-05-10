using System;
using System.Collections.Generic;
using System.Text;


namespace SpiralMatrix
{
    public class Matrix<T>
    {
        private Dimention dimention;
        private Dimention position;
        private T[,] matrixBase;
        public Matrix(Dimention p,Dimention begin)
        { 
            this.Dimention = p;
            this.Position = begin;
        
            this.MatrixBase=new T[p.Col,p.Row];
        }

        public Dimention Dimention
        {
            get { return dimention; }
            set { dimention = value; }
        }

        public Dimention Position
        {
            get { return position; }
            set { position = value; }
        }

        public T[,] MatrixBase
        {
            get
            {
               
                return this.matrixBase;
            }
            set
            {
                matrixBase = value;
            }
        }

        public T getValue(int col, int row)
        {
            return this.MatrixBase[col, row];
        }

        public void setValue(int col, int row, T value)
        {
            this.MatrixBase[col, row] = value;
        }
        public Dimention MoveLeft(Matrix<T> m, int step)
        {
           var left = new Dimention
            {
                Row =m.Position.Row +(-step),
                Col =m.Position.Col+ 0
            };

            return m.Position = left;
        }

        public Dimention MoveRight(Matrix<T> m, int step)
        {
            var right = new Dimention
            {
                Row = m.Position.Row+step,
                Col = m.Position.Col+ 0

            };
            return m.Position = right;
        }

        public Dimention MoveUp(Matrix<T> m, int step)
        {
            var up = new Dimention
            {
                Row = m.Position.Row+0,
                Col = m.Position.Col+(-step)

            };
            return m.Position = up;
        }
        public Dimention MoveDown(Matrix<T> m, int step)
        {
            var down = new Dimention
            {
                Row =m.Position.Row+ 0,
                Col =m.Position.Col+ step

            };
            return m.Position = down;
        }
        public override string ToString()
        {
            StringBuilder matrixtostring = new StringBuilder();

            for (int i = 0; i < MatrixBase.GetLength(0); i++)
            {
                for (int j = 0; j < this.MatrixBase.GetLength(1); j++)
                {
                     matrixtostring.Append(this.getValue(i,j).ToString());

                }
                matrixtostring.AppendLine();

            }
            return matrixtostring.ToString();
        }
    }

    public class Dimention
    {
        public int Col { get; set; }
        public int Row { get; set; }
    }

    class Program
    {
   
       
        static void Main(string[] args)
        {
            //int n = int.Parse(Console.ReadLine());
            //int[,] matrix = new int[n, n];
            //string direction = "right";
            //int row = 0;
            //int col = 0;

            //for (int i = 1; i <= n * n; i++)
            //{
            //    if (direction == "right" && (col >= n || matrix[row, col] != 0))
            //    {
            //        col--;
            //        row++;
            //        direction = "down";
            //    }
            //    else if (direction == "down" && (row >= n || matrix[row, col] != 0))
            //    {
            //        row--;
            //        col--;
            //        direction = "left";
            //    }
            //    else if (direction == "left" && (col < 0 || matrix[row, col] != 0))
            //    {
            //        col++;
            //        row--;
            //        direction = "up";
            //    }
            //    else if (direction == "up" && (row < 0 || matrix[row, col] != 0))
            //    {
            //        row++;
            //        col++;
            //        direction = "right";
            //    }

            //    matrix[row, col] = i;

            //    if (direction == "right")
            //    {
            //        col++;
            //    }
            //    else if (direction == "down")
            //    {
            //        row++;
            //    }
            //    else if (direction == "left")
            //    {
            //        col--;
            //    }
            //    else if (direction == "up")
            //    {
            //        row--;
            //    }
            //}

            //for (int i = 0; i < matrix.GetLength(0); i++)
            //{
            //    for (int j = 0; j < matrix.GetLength(1); j++)
            //    {
            //        Console.Write("{0} ", matrix[i, j]);
            //    }

            //    Console.WriteLine();
            //}
            Dimention matrixDimention=new Dimention();
            matrixDimention.Col = 6;
            matrixDimention.Row = 6;

            Dimention startPosition=new Dimention();
            startPosition.Col = 0;
            startPosition.Row = 0;

            Matrix<double> m=new Matrix<double>(matrixDimention,startPosition);

            m.Dimention.Col = 4;
            m.Dimention.Row = 4;
   
            int count = 0;

            while (count< m.Dimention.Row)
            {
            
                int 
                m.setValue(m.MoveLeft(m, 1).Col, m.MoveLeft(m, 1).Row, count);
                m.Position.Row=count++;
                

            }

            Console.WriteLine(m.ToString());


        }
    }
}
