
namespace Console
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Console.WriteLine("Hello World!");
            Table book = new Table();
            book.AddData(91);
            book.AddData(89.5f);
            //System.Console.WriteLine(89.5);

            Statistics stats = book.ComputeStatistics();

            Table book2 = new Table();
            book2.AddData(76);
        }
    }
}
