internal class Program
    {

private static void Main(string[] args)
    {
        Console.WriteLine("Nhap do dai cua mang");
        int size=0;
        do
        {
            size = Convert.ToInt32(Console.ReadLine());

        } while (size>20);
        Console.WriteLine("OK");
        int[] myArrays = new int[size];
        for (int i = 0; i < myArrays.Length; i++)
        {
            myArrays[i] = Convert.ToInt32(Console.ReadLine());
        }
        for (int i = 0; i < myArrays.Length; i++)
        {
            Console.Write(myArrays[i]+",");
        }
        int maxValue = 0;
        for (int i = 0; i < myArrays.Length; i++)
        {
            if(maxValue<myArrays[i])
            {
                maxValue = myArrays[i];
            }
        }
        Console.WriteLine("gia tri lon nhat cua mang la "+maxValue);
    }
}