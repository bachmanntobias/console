using ScriptCs.SpeakR.ScriptPack;

namespace Console
{
    class Program
    {
        static void Main(string[] args)
        {
            //var speakr = new List<SpeakR>();
            //speakr.Speak("Hello speakr");
            //speakr.SpeakWrite("Hello speak and console.writeline");
          
            System.Console.WriteLine("Hello World!");
            Table book = new Table();
            book.AddData(91);
            book.AddData(89.5f);
            //System.Console.WriteLine(89.5);

            Table g1 = new Table();

            Statistics stats = book.ComputeStatistics();
            System.Console.WriteLine(stats.Average);
            System.Console.WriteLine(stats.Lowest);
        }
    }
}
