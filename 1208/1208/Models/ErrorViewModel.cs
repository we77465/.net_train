namespace _1208.Models
{
    public class ErrorViewModel
    {
        public string? RequestId { get; set; }

        public bool ShowRequestId => !string.IsNullOrEmpty(RequestId);
    }
    public class Menber
    {
        public int id { get; set; }
        public string Name { get; set; }
        public int age { get; set; }
        public string? RequestId { get; set; }

    }
}
