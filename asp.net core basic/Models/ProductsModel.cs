namespace asp.net_core_basic.Models
{
    public class Product
    {
        public string? Name { get; set; }
        public int? Id { get; set; }
        public Data? Data { get; set; }
    }

    public class Data
    {
        public string? CustomerName { get; set; }
        public int? CustomerAge { get; set; }
    }
    public class ProductPageViewModel
    {
        public List<Product>? Products { get; set; }
        public string? Message { get; set; }
        public List<Post>? JsonData { get; set; }

        public static implicit operator ProductPageViewModel(ProductPageViewModel v)
        {
            throw new NotImplementedException();
        }
    }
    public class Post
    {
        public int? Id { get; set; }
        public string? Title { get; set; }
        public string? Body { get; set; }
        public int? UserId { get; set; }
    }
}
