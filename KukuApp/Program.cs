namespace KukuApp
{
    public class Program
    {
        public static void Main(string[] args)
        {
            ShowKuku();
        }

        public static void ShowKuku()
        {
            for(int i = 1; i < 10; i++)
            {
                for(int j = 1; j < 10; j++)
                {
                    Console.Write(String.Format("{0,3}", i*j));
                }
                Console.WriteLine();
            }
        }
    }
}
