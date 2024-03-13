namespace Lab2_KO
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Problem problem = new Problem(1, 10);
            problem.Solve(20);
            problem.SeeResult();
        }
    }
}
