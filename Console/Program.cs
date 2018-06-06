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
            book.Name = "test";
            Table g1 = new Table();

            Statistics stats = book.ComputeStatistics();
            WriteResult("Durchschnitt", stats.Average);
            WriteResult("Niedrigster Wert",(int)stats.Lowest);

            float [] arr = new float[6];

      

        }

        static void WriteResult(string description, float result)
        {
            System.Console.WriteLine($"{description} : {result: F2}");
        }

        static void WriteResult(string description, int result)
        {
            System.Console.WriteLine("{0} : {1:F2}",description , result);
        }
    }
}
