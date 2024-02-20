using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AmrTaloniWebsite.Models
{
    public class HomePageModel
    {
        public IEnumerable<TbCompany>  lstItems  { get; set; }
        public TbCompany item { get; set; }

    }
}
