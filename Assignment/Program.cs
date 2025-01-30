namespace Assignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Q1
            var input = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int n = input[0], q = input[1];
            int[] arr = Console.ReadLine().Split().Select(int.Parse).ToArray();

            ArrayQuery queryHandler = new ArrayQuery(arr);

            for (int i = 0; i < q; i++)
            {
                int x = int.Parse(Console.ReadLine());
                Console.WriteLine(queryHandler.CountGreaterThan(x));
            }
            #endregion


        }
    }
}
