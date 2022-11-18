using CarShop.Domain.EntitiesValidators;
using CarShop.Domain.Shared;
using FluentValidation.Results;

namespace CarShop.Domain.Entities
{
    public class Customer : BaseEntity
    {
        protected Customer() { }

        public Customer(string firstName, string lastName, int age, string occupation, MartialStatusEnum martialStatus)
        {
            FirstName = firstName;
            LastName = lastName;
            Age = age;
            Occupation = occupation;
            MartialStatus = martialStatus;
        }

        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        public string Occupation { get; set; }
        public MartialStatusEnum MartialStatus { get; set; }

        public override ValidationResult Validate() => new CustomerValidators().Validate(this);
    }
}
