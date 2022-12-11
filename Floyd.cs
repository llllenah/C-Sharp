using System;
class Program {
    public static int inf = 9999;
    public static int tempSum;
    public static int[,] mas = new int[6, 6]{
            { 0,  7,  9,  inf,  inf, 14},
            { 7,  0, 10, 15,  inf,  inf},
            { 9, 10,  0, 11,  inf,  2},
            { inf, 15, 11,  0,  6,  inf},
            { inf,  inf,  inf,  6,  0,  9},
            {14,  inf,  2,  inf,  9,  0}
        };
    public static int[,] P = new int[6, 6]{
            { 1,  1,  1,  1,  1, 1},
            { 1,  1,  1,  1,  1, 1},
            { 1,  1,  1,  1,  1, 1},
            { 1,  1,  1,  1,  1, 1},
            { 1,  1,  1,  1,  1, 1},
            { 1,  1,  1,  1,  1, 1}
        };
    public static void matrixprint(int [,] matrix, string l){
        Console.WriteLine($"Матриця {l}: ");
        for (int i = 0; i < 6; i++){
            for (int j = 0; j < 6; j++)
                Console.Write("{0,4}", matrix[i, j]);
            Console.WriteLine();
        }
        Console.WriteLine();
    }
    public static void Floyd(){
        int n = 6;
        for (int k = 0; k < n; k++){
            for (int i = 0; i < n; i++){
                for (int j = 0; j < n; j++){
                    tempSum = mas[i, k] + mas[k, j];
                    if(tempSum < mas [i, j]){
                        mas[i, j] = tempSum;
                        P[i, j] = k + 1;
                    }
                }
            }
        }
    }
    static void Main(string[] args){
        Floyd();
        matrixprint(P, "найкоротших шляхів");
    }
}
