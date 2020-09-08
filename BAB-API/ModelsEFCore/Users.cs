using System;
using System.Collections.Generic;

namespace Models.EFCore
{
    public partial class Users
    {
        public Users()
        {
            Groups = new HashSet<Groups>();
        }

        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public DateTime? RegistrationDate { get; set; }
        public bool? IsActive { get; set; }
        public DateTime? CreatedDate { get; set; }
        public DateTime? UpdatedDate { get; set; }

        public virtual ICollection<Groups> Groups { get; set; }
    }
}
