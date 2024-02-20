using System;
using System.Collections.Generic;

#nullable disable

namespace AmrTaloniWebsite.Models
{
    public partial class TbCompany
    {
        public int CompanyId { get; set; }
        public string CompanyDescription { get; set; }
        public string CompanyImageName { get; set; }
        public string CreatedBy { get; set; }
        public string UpdatedBy { get; set; }
        public DateTime? CreatedDate { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public string Notes { get; set; }
    }
}
