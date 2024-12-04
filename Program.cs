namespace dz4;

class Program
{
    static void Main(string[] args)
    {
        int[] array1 = {11, 25, 16, 17, 12};
        int[] array2 = {1, 5, 2, 6, 7, 3, 9};
        int len = array1.Length + array2.Length;
        int[] itog = new int[len];

        for (int i = 0; i < array1.Length; i++){
            itog[i] = array1[i];
        }

        for (int j = 0; j < array2.Length; j++){
            itog[array1.Length + j] = array2[j];
        }
        foreach (int i in itog){
            Console.WriteLine(i);
        }
        
    }
}
