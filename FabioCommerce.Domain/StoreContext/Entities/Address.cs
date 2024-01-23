using FabioCommerce.Domain.StoreContext.Enums;

namespace FabioCommerce.Domain.StoreContext.Entities
{
    public class Address
    {
        public Address(
            string street,
            string number,
            string complement,
            string district,
            string city,
            string state,
            string country,
            string zipCode,
            EAdressDelivery type)
        {
            Street = street;
            Number = number;
            Complement = complement;
            District = district;
            City = city;
            State = state;
            Country = country;
            ZipCode = zipCode;
            Type = type;
        }
        public string Street { get; private set; }
        public string Number { get; private set; }
        public string Complement { get; private set; }
        public string District { get; private set; }
        public string City { get; private set; }
        public string State { get; private set; }
        public string Country { get; private set; }
        public string ZipCode { get; private set; }
        public EAdressDelivery Type { get; private set; }

        public override string ToString()
        {
            return $"{Street}, {Number}, {District}, {City}/{State}, CEP {ZipCode} - {Country}. {Complement}";
        }
    }
}
