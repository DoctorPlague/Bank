using System;
class age
{
    static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());
        Random r = new Random();

        int[] massiv = new int[n];
        for (int i = 0; i < n; i++)
        {
            massiv[i] = r.Next(10);
        }
        Console.WriteLine(massiv);
    }
}
