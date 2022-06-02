using P225Eterna.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace P225Eterna.ViewModel
{
    public class PriceingVM
    {
        public List<Plan> Plans { get; set; }
        public List<FeatureItem> FeatureItems { get; set; }
    }
}
