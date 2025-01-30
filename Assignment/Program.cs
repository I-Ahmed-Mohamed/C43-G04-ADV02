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


            #region Q2
            int N = int.Parse(Console.ReadLine());
            int[] Arry = Console.ReadLine().Split().Select(int.Parse).ToArray();

            PalindromeChecker checker = new PalindromeChecker();
            Console.WriteLine(checker.IsPalindrome(arr) ? "YES" : "NO");

            #endregion


            #region Q3
            Queue<int> queue = new Queue<int>(new int[] { 1, 2, 3, 4, 5 });
            QueueReverser reverser = new QueueReverser();

            reverser.ReverseQueue(queue);

            foreach (var item in queue)
            {
                Console.Write(item + " ");
            }
            #endregion


            #region Q4

            string Input = Console.ReadLine();
            ParenthesesBalancer balancer = new ParenthesesBalancer();
            Console.WriteLine(balancer.IsBalanced(Input) ? "Balanced" : "Unbalanced");

            #endregion

            #region Q5
            int[] Arr = Console.ReadLine().Split().Select(int.Parse).ToArray();
            DuplicateRemover remover = new DuplicateRemover();

            int[] uniqueArr = remover.RemoveDuplicates(Arr);
            Console.WriteLine(string.Join(" ", uniqueArr));
            #endregion

        }
    }
}
