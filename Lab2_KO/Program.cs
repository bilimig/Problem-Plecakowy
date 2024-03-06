namespace Lab2_KO
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Problem problem = new Problem(10, 10);
            problem.Solve(10);
            problem.SeeResult();
        }
    }
}
