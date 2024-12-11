namespace Assignment6_4_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[,] twoDArr = { { 1, 2, 3 }, { 4, 5, 6 }, { 7, 8, 9 } };
            RotateMatrix(twoDArr);

            int[,] twoDArr2 = { { 1, 2, 3, 4 }, { 5, 6, 7, 8 }, { 9, 10, 11, 12 }, { 13, 14, 15, 16 } };
            RotateMatrix(twoDArr2);

            int[,] twoDArr3 = { { 5, 1, 9, 11 }, { 2, 4, 8, 10 }, { 13, 3, 6, 7 }, { 15, 14, 12, 16 } };
            RotateMatrix(twoDArr3);
        }



        static void RotateMatrix(int[,] twoDArr)
        {
            Console.WriteLine("<==============================================NEW==============================================>");
            Console.WriteLine();
            Console.WriteLine("ORIGINAL MATRIX");
            Print2DArr(twoDArr);

            int n = twoDArr.GetLength(0);

            //Transpose matrix (arr[i, j] <-> arr[j, i])
            int temp = 0;
            for (int i = 0; i < n-1; i++)
            {
                for (int j = i + 1; j < n; j++)
                {
                    temp = twoDArr[i, j];
                    twoDArr[i,j] = twoDArr[j, i];
                    twoDArr[j, i] = temp;
                }
                
            }
            // Prints the transposed array befor row reversal
            Console.WriteLine("TRANSPOSED");
            Print2DArr(twoDArr);

            //Reverse each row (arr[i, j] <-> arr[i, n-1-j)
            temp = 0;
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n/2; j++)
                {
                    temp = twoDArr[i, j];
                    twoDArr[i, j] = twoDArr[i, n-1-j];
                    twoDArr[i, n-1-j] = temp;
                }

            }

            Console.WriteLine("TRANSPOSED + REVERSED ROWS");
            Print2DArr(twoDArr);
        }

        static void Print2DArr(int[,] twoDArr)
        {
            int rows = twoDArr.GetLength(0);
            int cols = twoDArr.GetLength(1);
            Console.WriteLine($"rows: {rows} cols: {cols}");
            for (int i = 0; i < rows; i++)
            {
                Console.Write("| ");
                for (int j = 0; j < cols; j++) 
                {
                    Console.Write(twoDArr[i,j] + " | ");
                }
                Console.WriteLine();              
            }
            Console.WriteLine();
        }
    }
}
