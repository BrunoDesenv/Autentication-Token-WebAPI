using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApisTokenAuth.Models
{
    public partial class ApplicationUser
    {
        public int Id { get; set; }
        public string EmailID { get; set; }
        public string UserName { get; set; }
        public byte[] Password { get; set; }
        public int RoleId { get; set; }

        public virtual UserRole UserRole { get; set; }

    }
}