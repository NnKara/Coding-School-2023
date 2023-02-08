using PetShop.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace PetShop.EF.Repository {
    public class MockRepoCustomers : EntityInterface<Customer> {

        private readonly List<Customer> _customers;
        public MockRepoCustomers() {
            _customers = new List<Customer>
            {

            new Customer {

                CustomerID = 1,
                CustomerName="Giannis",
                CustomerSurname="Katsaros",
                Phone="6978319552",
                TIN="01029783923"
            },

            new Customer {

                 CustomerID = 2,
                CustomerName="Petros",
                CustomerSurname="Xaikalis",
                Phone="6978314822",
                TIN="01089783923"
            },  

             new Customer {

                 CustomerID = 3,
                CustomerName="Marios",
                CustomerSurname="Koutroulis",
                Phone="6978389622",
                TIN="01089083923"
            }
        };
    }
    
        public void Add(Customer entity) {
            throw new NotImplementedException();
        }

        public void Delete(int id) {
            throw new NotImplementedException();
        }

        public IList<Customer> GetAll() {
            return _customers;
        }

        public Customer? GetByID(int id) {
            return _customers.SingleOrDefault(customer=>customer.CustomerID== id);
        }

        public void Update(int id, Customer entity) {
            throw new NotImplementedException();
        }
    }
}
