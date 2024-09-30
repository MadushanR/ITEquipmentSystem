namespace Assignment1.Models
{
    public static class Repository
    {
        private static List<Request> responses = new();
        public static IEnumerable<Request> Responses => responses;
        public static void AddResponse(Request response)
        {
            Console.WriteLine(response); responses.Add(response);
        }
    }
}
