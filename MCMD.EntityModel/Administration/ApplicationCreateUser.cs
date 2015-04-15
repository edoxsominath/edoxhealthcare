using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MCMD.EntityModel.Administration
{
    class ApplicationCreateUser
    {

        public string UserFirstName { get; set; }

        public string UserLastName { get; set; }

        public int EmpID { get; set; }

        public string UserEmail { get; set; }

        public string UserPassword { get; set; }

        public string UserRole { get; set; }

        public string Status { get; set; }

        public DateTime? CreateOnDate { get; set; }

        public int CreateById { get; set; }

        public DateTime? ModifyOnDate { get; set; }

        public int ModifyById { get; set; }
    }          
}
