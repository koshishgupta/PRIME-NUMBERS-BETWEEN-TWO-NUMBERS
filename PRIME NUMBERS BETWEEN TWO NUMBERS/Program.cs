namespace PRIME_NUMBERS_BETWEEN_TWO_NUMBERS
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a, b, i, j;
            Console.WriteLine("ENTER A TWO NUMBER  ");
             a=Convert.ToInt32(Console.ReadLine());
             b=Convert.ToInt32(Console.ReadLine());
            for( i = a; i <= b; i++)
            {
                for( j=2;j <= b; j++)
                {
                    if (i % j == 0)
                        break;
                }
       
                if (i==j)
                
                    Console.WriteLine(j);
                
            }
        }
    }
}
