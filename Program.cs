namespace LineComparisonProblem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Line Comparison Problem");

            int x1, y1, x2, y2;

            Console.Write("\nEnter x1 co-ordinate: ");
            x1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter y1 co-ordinate: ");
            y1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("\nEnter x2 co-ordinate: ");
            x2 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter y2 co-ordinate: ");
            y2 = Convert.ToInt32(Console.ReadLine());

            double lengthOfLine = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));
            Console.WriteLine($"\nlength of the Line is {lengthOfLine}");
        }
    }
}