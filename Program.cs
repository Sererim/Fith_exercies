
int Main()
{
    ushort size = 5;
    string key = "0";
    int[] arr = new int [size];
    int[] find = new int [3];
    while(true)
    {

        Console.WriteLine("Enter size of an array.");
        key = Console.ReadLine();
        size = System.UInt16.Parse(key);
        
        Console.WriteLine("Enter 'Y' if you want to manualy fill an array with numbers.");
        key = Console.ReadLine();
        if(key == "Y" || key == "y")
        {
            Console.WriteLine("Enter numbers to fill the array.");
            for(int i = 0; i < arr.Length; i++)
            {
                key = Console.ReadLine();
                arr[i] = System.Int32.Parse(key);
            }
        }
        else
            arr = Homework.GetMatrix(size);

        Console.WriteLine("Enter 1 to find how many even numbers are in the array.\n" +
        "Enter 2 to find a sum of elements on odd positions.\n" +
        "Enter 3 to find a difference between min and max value of elements in the array.\n" +
        "Enter 4 to find the longest series of numbers in the array.\n" +
        "\u001b[31mWarning if numbers in the array were randomly generated no series of number is present.\u001b[0m\n" + 
        "Enter 0 to terminate a program.");

        key = Console.ReadLine();

        switch(key)
        {
            case "1":
                Homework.ShowMatrix(arr);
                Console.WriteLine($"~{Homework.GetEven(arr)}~");
                break;

            case "2":
                Homework.ShowMatrix(arr);
                Console.WriteLine($"~{Homework.GetOddSum(arr)}~");
                break;

            case "3":
                Homework.ShowMatrix(arr);
                Console.WriteLine($"~{Homework.GetMinAndMax(arr)}~");
                break;

            case "4":
                Homework.ShowMatrix(arr);
                find = Homework.Find(arr);
                Console.WriteLine($"Number is {find[0]}\nPlace of the number is {find[1]}\nAmount of number is {find[2]}");
                break;

            case "0":
                return 0;

            default:
                Main();
                break;
        }
        Main();
    }
}

Main();

class Homework{

    // Method for an array generation, because there are multiple arrays to be generated.
    // Still main will have only one array.
    public static int[] GetMatrix(ushort size)
    {
        int[] matrix = new int [size];
        Random rand = new Random();

        for(int i = 0; i < matrix.Length; i++)
            matrix[i] = rand.Next(-1000, 1000);

        return matrix;
    }

    // Method for showing an array.
    public static void ShowMatrix(int[] matrix)
    {
        for(int i = 0; i < matrix.Length; i++)
            Console.Write($"|{matrix[i]}| ");
        Console.WriteLine();
    }

    // Method for counting even numbers.
    public static ushort GetEven(int[] matrix)
    {
        ushort foo = 0;
        foreach(int i in matrix)
            if(i % 2 == 0)
                foo++;
        
        return foo;
    }

    // Method for finding a sum of numbers at odd positions.
    public static int GetOddSum(int[] matrix)
    {
        int foo = 0;
        for(int i = 0; i < matrix.Length; i++)
            if(i % 2 != 0)
                foo += matrix[i];
        
        return foo;
    }

    // Method for finding a difference between max and min elements in an array.
     public static int GetMinAndMax(int[] matrix)
    {
        int foo = matrix[0], bar = matrix[1];

        for(int i = 0; i < matrix.Length; i++)
        {
            if(foo < matrix[i])
                foo = matrix[i];

            if(bar > matrix[i])
                bar = matrix[i];
        }
        foo -= bar;
        return foo;
    }


    public static int[] Find(int[] matrix)
    {
        int num = 0, place = 0, amount = 0;

        for(int i = 0; i < matrix.Length; i++)
            if(i < matrix.Length - 2)
                if(matrix[i] == matrix[i+1])
                {
                    num = matrix[i];
                    place = i;
                    amount++;
                }
    int[] answer = new int[3] {num,place,amount};

    return answer;

    }
}