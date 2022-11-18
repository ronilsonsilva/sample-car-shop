namespace CarShop.Shared.DTOs
{
    public class CarDto : BaseDto 
    {
        public string Make { get; set; }
        public string Model { get; set; }
        public int Years { get; set; }
        public string Colors { get; set; }
        public decimal Price { get; set; }
        public int Doors { get; set; }
    }
}
