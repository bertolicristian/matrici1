namespace esercizio1_matrici
{
    internal class Program
    {
        static int somma(int[,] M)
        {
            int somma = 0;

            for (int i = 0; i < M.GetLength(0); i++)
            {
                for (int j = 0; j < M.GetLength(1); j++)
                {
                    somma = somma + M[i, j];
                }
            }

            return somma;
        }

        static float media (int[,] M)
        {

            float somma = 0;

            float media = 0;

            for (int i = 0; i < M.GetLength(0); i++)
            {
                for (int j = 0; j < M.GetLength(1); j++)
                {
                    somma = somma + M[i, j];
                }
            }

            media = somma / M.Length;

            return media;
        }

        static int min(int[,] M)
        {
            int min = M[0, 0];

            for (int i = 0;i < M.GetLength(0); i++)
            {
                for(int j = 0; j < M.GetLength(1); j++)
                {
                    if (M[i, j] < min)
                    {
                       min = M[i, j];  
                    }
                }
            }

            return min;
        }

        static int max (int[,] M)
        {
            int max = M[0,0];

            for (int i = 0; i < M.GetLength (0); i++)
            {
                for (int j = 0; j < M.GetLength (1); j++)
                {
                    if (M[i, j] > max) 
                    {
                        max = M[i, j];
                    }
                   
                }
            }

            return max;
        }


        static void Main(string[] args)
        {
            int es1 = 0, es3 = 0, es4 = 0;
            float es2 = 0;

            int[,] M = { { 2, 7, 6 }, { 3, 5, 7 }, { 4, 6, 8 } };

            es1 = somma(M);

            Console.WriteLine(es1);

            es2 = media(M);

            Console.WriteLine(es2);

            es3 = min(M);

            Console.WriteLine(es3);

            es4 = max(M);

            Console.WriteLine(es4);

        }
    }
}