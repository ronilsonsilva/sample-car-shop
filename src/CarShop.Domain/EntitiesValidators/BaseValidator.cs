using CarShop.Domain.Entities;
using CarShop.Domain.Shared;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarShop.Domain.EntitiesValidators
{
    public abstract class BaseValidator<TEntity> : AbstractValidator<TEntity> where TEntity : BaseEntity
    {

    }

    public class CarValidators : BaseValidator<Car>
    {
        public CarValidators()
        {

        }
    } 

    public class OrderValidators : BaseValidator<Order>
    {
        public OrderValidators()
        {

        }
    }

    public class OrderDetailsValidators : BaseValidator<OrderDetails>
    {
        public OrderDetailsValidators()
        {

        }
    }

    public class CustomerValidators : BaseValidator<Customer>
    {
        public CustomerValidators()
        {

        }
    }
}
