namespace CarShop.Shared.DTOs
{
    public class CreateCustomerDto
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        public string Occupation { get; set; }
        public MartialStatusEnumDto MartialStatus { get; set; }
    }
}
