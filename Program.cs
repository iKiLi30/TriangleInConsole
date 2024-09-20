namespace TriangleInConsole
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Input a heigth of a triangle: ");
            int heigth = int.Parse(Console.ReadLine());
            for (int i = 0; i < heigth; i++)
            {
                for (int j = heigth; j > i; j--)
                {
                    Console.Write(" ");
                }

                for (int j = 0; j <= i; j++)
                {

                    Console.Write("*");
                }
                Console.WriteLine();

            }
            Console.WriteLine();

            for (int i = 0; i < heigth; i++)
            {
                for (int j = heigth; j > i; j--)
                {
                    Console.Write("*");
                }

                for (int j = 0; j <= i; j++)
                {

                    Console.Write(" ");
                }
                Console.WriteLine();

            }
                       
        }
    }
}
