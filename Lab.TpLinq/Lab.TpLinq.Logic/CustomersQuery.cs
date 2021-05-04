using Lab.TpLinq.Entites;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab.TpLinq.Logic
{
    public class CustomersQuery : BaseLogic
    {
        public List<Customers> EjercicioCuatro()
        {
            var query = from customers in context.Customers
                        where customers.Region == "WA"
                        select customers;

            return query.ToList();
        }
        public List<Customers> EjercicioSeis()
        {
            var query = from customer in context.Customers
                        select customer;

            return query.ToList();
        }
        public IQueryable EjercicioSiete()
        {
            var date = new DateTime(1997, 1, 1);
            var query = from customer in context.Customers
                        join order in context.Orders
                        on customer.CustomerID equals order.CustomerID
                        where customer.Region == "WA" && order.OrderDate > date
                        select new
                        {
                            customer.ContactName,
                            order.OrderDate
                        };

            return query;
        }

        public List<Customers> EjercicioOcho()
        {
            var query = context.Customers.Where(c => c.Region == "WA")
                                         .Take(3)
                                         .ToList();
            return query;
        }
    }
}

