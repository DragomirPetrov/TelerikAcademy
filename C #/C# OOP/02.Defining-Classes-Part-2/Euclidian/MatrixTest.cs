namespace Euclidian
{
    using System;

    class MatrixTest
    {
        public static void MainTest()
        {
            Console.WriteLine(Environment.NewLine
                + "Matrix Test: "
                + Environment.NewLine);

            var matrix1 = new Matrix<int>(3, 2);
            var matrix2 = new Matrix<int>(2, 2);
           
            matrix1[0, 0] = 4;
            matrix1[0, 1] = 8;
            matrix1[1, 0] = 0;
            matrix1[1, 1] = 2;
            matrix1[2, 0] = 1;
            matrix1[2, 1] = 6;

            matrix2[0, 0] = 5;
            matrix2[0, 1] = 2;
            matrix2[1, 0] = 9;
            matrix2[1, 1] = 4;
            

            var resultProduct = matrix1 * matrix2;

            if (matrix2)
            {
                Console.WriteLine("There are no zeroes!");
            }
            else
            {
                Console.WriteLine("Yes, there are zeroes!");
            }
        }
    }
}
