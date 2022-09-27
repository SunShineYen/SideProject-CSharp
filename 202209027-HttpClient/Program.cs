class Program
{
    private const string uri = "http://api.geonames.org/search";

    static void Main(string[] args)
    {
        _ = RunSendAsync();

        Console.WriteLine("Hit enter to exit...");
        Console.ReadKey();
    }

    static async Task RunSendAsync()
    {
        using (HttpClient client = new HttpClient()) 
        {
            HttpRequestMessage httpRequest = new HttpRequestMessage(HttpMethod.Get, uri);

            await client.SendAsync(httpRequest).ContinueWith(responseTask => {
                Console.WriteLine("Response: {0}", responseTask.Result);
            });
        }
    }
}