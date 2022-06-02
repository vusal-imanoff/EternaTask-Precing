using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace P225Eterna.Models
{
    public class Plan
    {
        public int Id { get; set; }
        public double Price { get; set; }
        public string Name { get; set; }
        public bool IsFeature { get; set; }
        public List<PlanFeature> PlanFeatures { get; set; }

    }
}
