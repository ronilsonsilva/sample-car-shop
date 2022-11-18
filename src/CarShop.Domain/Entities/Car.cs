using CarShop.Domain.EntitiesValidators;
using CarShop.Domain.Shared;
using FluentValidation.Results;

namespace CarShop.Domain.Entities
{
    public class Car : BaseEntity
    {
        public Car(string make, string model, int years, string colors, decimal price, int doors)
        {
            Make = make;
            Model = model;
            Years = years;
            Colors = colors;
            Price = price;
            Doors = doors;
        }

        protected Car() { }

        public string Make { get; set; }
        public string Model { get; set; }
        public int Years { get; set; }
        public int Doors { get; set; }
        public string Colors { get; set; }
        public decimal Price { get; set; }

        public override ValidationResult Validate() => new CarValidators().Validate(this);
    }
}
