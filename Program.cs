namespace LineComparisonProblem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Line Comparison Problem");

            Console.WriteLine("\n==========Line 1==========\n");
            int x1, y1, x2, y2;
            Console.Write("Enter x1 co-ordinate: ");
            x1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter y1 co-ordinate: ");
            y1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter x2 co-ordinate: ");
            x2 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter y2 co-ordinate: ");
            y2 = Convert.ToInt32(Console.ReadLine());
            double lengthOfLine1 = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));
            Console.WriteLine($"\nLength of the Line is {lengthOfLine1}");

            Console.WriteLine("\n==========Line 2==========\n");
            int a1, b1, a2, b2;
            Console.Write("Enter a1 co-ordinate: ");
            a1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter b1 co-ordinate: ");
            b1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter a2 co-ordinate: ");
            a2 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter b2 co-ordinate: ");
            b2 = Convert.ToInt32(Console.ReadLine());
            double lengthOfLine2 = Math.Sqrt(Math.Pow(a2 - a1, 2) + Math.Pow(b2 - b1, 2));
            Console.WriteLine($"\nLength of the Line is {lengthOfLine2}");

            if (int.Equals(lengthOfLine1, lengthOfLine2))
            {
                Console.WriteLine("The two lines are Equal");
            }
            else
            {
                Console.WriteLine("The two lines are Not Equal");
            }
        }
    }
}