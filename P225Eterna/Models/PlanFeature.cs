using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace P225Eterna.Models
{
    public class PlanFeature
    {
        public int Id { get; set; }
        public int PlanId { get; set; }
        public Plan Plan { get; set; }
        public int FeatureItemId { get; set; }
        public FeatureItem FeatureItem { get; set; }
    }
}
