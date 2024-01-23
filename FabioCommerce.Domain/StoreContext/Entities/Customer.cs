﻿using FabioCommerce.Domain.StoreContext.ValueObjects;

namespace FabioCommerce.Domain.StoreContext.Entities
{
    public class Customer
    {

        public Customer(
            Name name,
            Document document,
            Email email,
            string phone)
        {
            Name = name;
            Document = document;
            Email = email;
            Phone = phone;
            Addresses = new List<Address>();
        }

        public Name Name { get; private set; }
        public Document Document { get; private set; }
        public Email Email { get; private set; }
        public string Phone { get; private set; }
        public IReadOnlyCollection<Address> Addresses { get; private set; }

        public override string ToString()
        {
            return Name.ToString();
        }
    }
}
