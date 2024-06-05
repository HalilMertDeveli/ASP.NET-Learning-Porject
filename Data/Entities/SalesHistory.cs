namespace AspNetEntity.Data.Entities
{
    public class SalesHistory
    {
        
        public int Id { get; set; }
        

        //naviagation proprty
        public int ProductId { get; set; }
        public Product Product { get; set; }

        public int Amount { get; set; }

    }
}
