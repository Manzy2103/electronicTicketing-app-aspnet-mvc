namespace eTickets.Helpers.Models
{
    public class OutputResponse
    {
        public string Message { get; set; }
        public bool IsErrorOccurred { get; set; }
        public object Result { get; set; }
    }
}
