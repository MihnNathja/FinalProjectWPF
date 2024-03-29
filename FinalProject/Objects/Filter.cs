using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject.Objects
{
    public class Filter
    {
        string location;
        string experience;
        public Filter()
        {
            location = string.Empty;
            experience = string.Empty;
        }
        public Filter(string location, string experience)
        {
            this.location = location;
            this.experience = experience;
        }

        public string Location { get => location; set => location = value; }
        public string Experience { get => experience; set => experience = value; }
    }
}
