using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Sneha_S_301096645.Models.ViewModels
{
    public class ClubListViewModel
    {
        public IEnumerable<ClubResponse> Clubs { get; set; }
        public PagingInfo PagingInfo { get; set; }
    }
}
