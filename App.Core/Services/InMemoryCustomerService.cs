using App.Core.Models;
using App.Core.Contracts;
using System;
using System.Collections.Generic;
using System.Text;

namespace App.Core.Services
{
    public class InMemoryCustomerService : ICustomerService
    {
        private List<Customer> _customers = new List<Customer>();

         List<Customer> ICustomerService.GetAll()
        {
            return _customers.ToList();
        }
         Customer ICustomerService.GetById(string id)
        {
            return _customers.FirstOrDefault(c => c.Id == id);
        }
         void ICustomerService.Add(Customer customer)
        {
            if (customer == null)
                throw new ArgumentNullException("Customer Object is null");
            _customers.Add(customer);
        }
        void ICustomerService.Update(Customer customer)
        {
            if (customer == null)
                throw new ArgumentNullException("Customer Object is null");
           
            var existing = _customers.FirstOrDefault(c => c.Id == customer.Id);
            if (existing == null)
            throw new ArgumentException($"Customer with {customer.Id} not found");

            existing.Name = customer.Name;
            existing.Email = customer.Email;
            existing.Phone = customer.Phone;
            existing.Address = customer.Address;
        }
         void ICustomerService.Delete(String id)
        {
            _customers.RemoveAll(c => c.Id == id);
        }
         List<Customer> ICustomerService.Search(string query)
        {
            if (string.IsNullOrWhiteSpace(query))
                return ((ICustomerService)this).GetAll();

            return _customers.Where(c => c.Name.Contains(query, StringComparison.OrdinalIgnoreCase)).ToList();
        }
    }
}
