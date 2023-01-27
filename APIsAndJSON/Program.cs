namespace APIsAndJSON
{
    public class Program
    {
        static void Main(string[] args)
        {
            var client = new HttpClient();
            var quote = new QuoteGenerator(client);

            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("------------------------");
                Console.WriteLine($"Kanye: {quote.KanyeResponse()}");

                Console.WriteLine($"Ron Swanson: {quote.RonSwansonResponse()}");
        }   }
    }
}
