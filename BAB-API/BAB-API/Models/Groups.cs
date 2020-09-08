using System;
using System.Collections.Generic;

namespace BAB_API.Models
{
    public partial class Groups
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int? AdminId { get; set; }
        public DateTime? CreatedDate { get; set; }
        public bool? IsActive { get; set; }

        public virtual Users Admin { get; set; }
    }
}
