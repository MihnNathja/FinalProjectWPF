using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject.Objects
{
    public class Company : User
    {
        string mst;
        string locationCompany;
        string companyRepresentative;
        string phoneNumber;

        public Company() 
        {
            Type = "Company";
        }
        public Company(string userName, string password, string companyName, string mst, string locationCompany, string companyRepresentative, string phoneNumber)
        : base (userName, password, companyName, phoneNumber, locationCompany)
        {
            Type = "Company";
            this.mst = mst;
            this.locationCompany = locationCompany;
            this.companyRepresentative = companyRepresentative;
        }

        public string Mst { get => mst; set => mst = value; }
        public string CompanyRepresentative { get => companyRepresentative; set => companyRepresentative = value; }

    }
}
