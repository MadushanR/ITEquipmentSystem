namespace Assignment1.Models
{
    public static class Repository
    {
        private static List<Request> responses = new();
        private static int Id = 1;
        public static IEnumerable<Request> Responses => responses;
        public static void AddResponse(Request response)
        {
            response.Id = Id++;
            responses.Add(response);
        }
    }
}
