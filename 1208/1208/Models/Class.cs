namespace _1208.Models
{
    public class Member
    {
        public int Id { get; set; }
        public string? Name { get; set; } 
        public int Age { get; set; }
        public string? RequestId { get; set; }

    }

    public class Product
    {
        public int Number{get;set;}
        
        public string? Name{get;set;}

        public int Price{get;set;}
    }

    public class MemberInfoViewModel
    {
        public Member ?Member { get; set; }
        public List<Product> ?Products { get; set; }
    }
}
