using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TanCruzDentalInventorySystem.ViewModel
{
    public class UserProfileViewModel
    {
        public int UserId { get; set; }
        public int UserGroupId { get; set; }
        public string Password { get; set; }
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string RowStatus { get; set; }
    }
}