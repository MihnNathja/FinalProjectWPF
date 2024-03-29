using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject.Objects
{
    public class Company
    {
        string companyName;
        string mst;
        string locationCompany;
        string companyRepresentative;
        string phoneNumber;

        public Company() {}
        public Company(string companyName, string mst, string locationCompany, string companyRepresentative, string phoneNumber)
        {
            this.companyName = companyName;
            this.mst = mst;
            this.locationCompany = locationCompany;
            this.companyRepresentative = companyRepresentative;
            this.phoneNumber = phoneNumber;
        }

        public string CompanyName { get => companyName; set => companyName = value; }
        public string Mst { get => mst; set => mst = value; }
        public string LocationCompany { get => locationCompany; set => locationCompany = value; }
        public string CompanyRepresentative { get => companyRepresentative; set => companyRepresentative = value; }
        public string PhoneNumber { get => phoneNumber; set => phoneNumber = value; }


    }
}
