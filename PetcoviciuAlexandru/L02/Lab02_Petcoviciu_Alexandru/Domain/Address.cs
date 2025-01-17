﻿using System.Text.RegularExpressions;

namespace Lab02_Petcoviciu_Alexandru
{
    public record Address
    {
        private static readonly Regex ValidPattern = new("{str, nr}");

        public string _address { get; }

        public Address(string address)
        {
            if (ValidPattern.IsMatch(address))
            {
                _address = address;
            }
            else
            {
                throw new Domain.InvalidAddressException("");
            }
        }

        public override string ToString()
        {
            return _address;
        }
        private static bool IsValid(string stringValue) => ValidPattern.IsMatch(stringValue);

        public static bool TryParse(string addressString, out Address address)
        {
            bool isValid = false;
            address = null;
            if (IsValid(addressString))
            {
                isValid = true;
                address = new(addressString);
            }
            return isValid;
        }

    }
}
