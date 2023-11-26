internal class Arr_treat
{
    public static void Ar_sum(int[] b, int n)
    {
        int sum = 0;
        for (int i = 0; i < n; i++)
        {
           sum += b[i];
        }
        Console.WriteLine("Number in array: {0}, Sum: {1}", n, sum);
    }
    public static void Ar_avg(int[] b, int n)
    {
        int sum = 0;
        for (int i = 0; i < n; i++)
        {
            sum += Math.Abs(b[i]);
        }
        double med = sum/ n;
        Console.WriteLine("Average ariphmetical for array: {0:F2}", med);
    }
    public static void Ar_pos_and_neg(int[] b, int n)
    {
        int sumpos = 0, sumneg = 0;
        for (int i = 0; i < n; i++)
        {
            switch (b[i])
            { 
                case > 0: sumpos += b[i];
                    break;
                case < 0: sumneg += (b[i]);
                    break;
                case (0):
                    break;
            }
        }
        Console.WriteLine("Sum of postive elements: {0}", sumpos);
        Console.WriteLine("Sum of negative elements: {0}", Math.Abs(sumneg));

    }
    private static void Main(string[] args)
    {
        Console.WriteLine("Enter an ammount of numbers in array");
        int n = int.Parse(Console.ReadLine());
        int[] Arr= new int[n];
        for (int i = 0; i < n; i++)
        {
            Console.WriteLine("Number No {0}", i + 1);
            Arr[i] = int.Parse(Console.ReadLine());
        }
        Ar_sum(Arr, n);
        Ar_avg(Arr, n);
        Ar_pos_and_neg(Arr, n);

        Console.Read();
    }
}