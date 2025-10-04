namespace algoritm1;

class Program
{
    static void Main(string[] args)
    {

        //task1
        //int a = 4;
        //int b = 3;
        //int c = 5;
        //if (((a * a) + (b * b)) == (c*c))

        //    Console.WriteLine("Pryamouqolniy treuqolnik");

        //else
        //    Console.WriteLine("ne pryamouqolniy treuqolnik");


        //task2
        //string s = "Salam";
        //int m = s.Length;
        //if (m % 2 == 1)
        //    Console.WriteLine(s[m / 2]);
        //else
        //    Console.WriteLine(s[m / 2 - 1].ToString() + s[m / 2].ToString());


        //task3
        //int n = 378;
        //int sum = 0;
        //while (n>0)
        //{
        //    int m = n % 10;
        //    if (m % 2 == 1)
        //    {
        //        sum += m;
        //    }
        //    n = n / 10;
        //}
        //Console.WriteLine(sum);

        //task4
        int x = 100;
        int y = 30;
        int max = -1;
        for (int i = 0; i <x; i++)
        {
            if (i % y == 0)
            {
                max = i;
            }
        }
        Console.WriteLine(max);



    }
}

