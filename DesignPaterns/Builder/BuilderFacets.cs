using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPaterns.BuilderFacets
{
    public class Person
    {
        // address
        public string StreetAddress { get => _streetAddress; set => _streetAddress = value; }
        private string _streetAddress;

        public string PostCode { get => _postCode; set => _postCode = value; }
        private string _postCode;

        public string City { get => _city; set => _city = value; }
        private string _city;


        // employment
        public string CompanyName { get => _companyName; set => _companyName = value; }
        private string _companyName;

        public string Position { get => _position; set => _position = value; }
        private string _position;

        public int AnnualIncome { get => _annualIncome; set => _annualIncome = value; }
        private int _annualIncome;

        public override string ToString()
        {
            return $"{nameof(StreetAddress)}: {StreetAddress}, {nameof(PostCode)}: {PostCode}, {nameof(City)}: {City}, {nameof(CompanyName)}: {CompanyName}, {nameof(Position)}: {Position}, {nameof(AnnualIncome)}: {AnnualIncome}";
        }
    }

    public class BuilderFacets
    {
        public void Run()
        {

        }
    }
}
