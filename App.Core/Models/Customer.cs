using System;
using System.Collections.Generic;
using System.Text;

namespace App.Core.Models
{
    public class Customer
    {
        public string Id { get; set; }   // optional
        public string Name { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public string Address { get; set; }

        public Customer() {
            //sample: 12345678-1234-1234-1234-123456789012
            Id = "C-" + Guid.NewGuid().ToString("N").Substring(0,9);
        }
    }
}
