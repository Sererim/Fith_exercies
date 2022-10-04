
int Main()
{

    ushort size = 5;
    int[] matrix = new int [5] {0, 0, 0, 0, 0};
    Homework.ShowMatrix(matrix);
    Console.WriteLine();
    return 0;

}

Main();

class Homework{

    public static void ShowMatrix(int[] matrix)
    {
        for(int i = 0; i < matrix.Length; i++)
            Console.Write($"|{matrix[i]}| ");
        Console.WriteLine();
    }


}