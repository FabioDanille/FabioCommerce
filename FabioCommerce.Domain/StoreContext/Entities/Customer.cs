﻿using FabioCommerce.Domain.StoreContext.ValueObjects;

namespace FabioCommerce.Domain.StoreContext.Entities
{
    public class Customer
    {
        private readonly IList<Address> _addresses;

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
            _addresses = new List<Address>();
        }

        public Name Name { get; private set; }
        public Document Document { get; private set; }
        public Email Email { get; private set; }
        public string Phone { get; private set; }
        public IReadOnlyCollection<Address> Addresses => _addresses.ToArray();

        public override string ToString()
        {
            return Name.ToString();
        }

        public void AddAddres(Address address)
        {
            _addresses.Add(address);
        }
    }
}
