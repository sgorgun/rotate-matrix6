using System;

namespace RotateMatrix
{
    public static class ArrayExtensions
    {
        /// <summary>
        /// Rotates the image clockwise by 90° in place.
        /// </summary>
        /// <param name="matrix">Two-dimension square matrix that presents an image.</param>
        /// <exception cref="ArgumentNullException">Throw when source matrix is null.</exception>
        public static void Rotate90DegreesClockwise(this int[,]? matrix)
        {
            if (matrix is null)
            {
                throw new ArgumentNullException(nameof(matrix));
            }

            int n = matrix.GetLength(0);

            for (int i = 0; i < n / 2; i++)
            {
                for (int j = i; j < n - i - 1; j++)
                {
                    int temp = matrix[i, j];
                    matrix[i, j] = matrix[n - j - 1, i];
                    matrix[n - j - 1, i] = matrix[n - i - 1, n - j - 1];
                    matrix[n - i - 1, n - j - 1] = matrix[j, n - i - 1];
                    matrix[j, n - i - 1] = temp;
                }
            }
        }

        /// <summary>
        /// Rotates the image counterclockwise by 90° in place.
        /// </summary>
        /// <param name="matrix">Two-dimension square matrix that presents an image.</param>
        /// <exception cref="ArgumentNullException">Throw when source matrix is null.</exception>
        public static void Rotate90DegreesCounterClockwise(this int[,]? matrix)
        {
            if (matrix is null)
            {
                throw new ArgumentNullException(nameof(matrix));
            }

            int n = matrix.GetLength(0);

            for (int i = 0; i < n / 2; i++)
            {
                for (int j = i; j < n - i - 1; j++)
                {
                    int temp = matrix[i, j];
                    matrix[i, j] = matrix[j, n - i - 1];
                    matrix[j, n - i - 1] = matrix[n - i - 1, n - j - 1];
                    matrix[n - i - 1, n - j - 1] = matrix[n - j - 1, i];
                    matrix[n - j - 1, i] = temp;
                }
            }
        }

        /// <summary>
        /// Rotates the image clockwise by 180° in place.
        /// </summary>
        /// <param name="matrix">Two-dimension square matrix that presents an image.</param>
        /// <exception cref="ArgumentNullException">Throw when source matrix is null.</exception>
        public static void Rotate180DegreesClockwise(this int[,]? matrix)
        {
            matrix.Rotate90DegreesClockwise();
            matrix.Rotate90DegreesClockwise();
        }

        /// <summary>
        /// Rotates the image counterclockwise by 180° in place.
        /// </summary>
        /// <param name="matrix">Two-dimension square matrix that presents an image.</param>
        /// <exception cref="ArgumentNullException">Throw when source matrix is null.</exception>
        public static void Rotate180DegreesCounterClockwise(this int[,]? matrix)
        {
            matrix.Rotate90DegreesCounterClockwise();
            matrix.Rotate90DegreesCounterClockwise();
        }

        /// <summary>
        /// Rotates the image clockwise by 270° in place.
        /// </summary>
        /// <param name="matrix">Two-dimension square matrix that presents an image.</param>
        /// <exception cref="ArgumentNullException">Throw when source matrix is null.</exception>
        public static void Rotate270DegreesClockwise(this int[,]? matrix)
        {
            matrix.Rotate180DegreesClockwise();
            matrix.Rotate90DegreesClockwise();
        }

        /// <summary>
        /// Rotates the image counterclockwise by 270° in place.
        /// </summary>
        /// <param name="matrix">Two-dimension square matrix that presents an image.</param>
        /// <exception cref="ArgumentNullException">Throw when source matrix is null.</exception>
        public static void Rotate270DegreesCounterClockwise(this int[,]? matrix)
        {
            matrix.Rotate180DegreesCounterClockwise();
            matrix.Rotate90DegreesCounterClockwise();
        }

        /// <summary>
        /// Rotates the image clockwise by 360° in place.
        /// </summary>
        /// <param name="matrix">Two-dimension square matrix that presents an image.</param>
        /// <exception cref="ArgumentNullException">Throw when source matrix is null.</exception>
        public static void Rotate360DegreesClockwise(this int[,]? matrix)
        {
            matrix.Rotate180DegreesClockwise();
            matrix.Rotate180DegreesClockwise();
        }

        /// <summary>
        /// Rotates the image counterclockwise by 360° in place.
        /// </summary>
        /// <param name="matrix">Two-dimension square matrix that presents an image.</param>
        /// <exception cref="ArgumentNullException">Throw when source matrix is null.</exception>
        public static void Rotate360DegreesCounterClockwise(this int[,]? matrix)
        {
            matrix.Rotate180DegreesCounterClockwise();
            matrix.Rotate180DegreesCounterClockwise();
        }
    }
}
