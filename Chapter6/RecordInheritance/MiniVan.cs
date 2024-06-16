using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecordInheritance
{
    sealed class MiniVan:Car
    {
        public int Seating { get; init; }
        public MiniVan(string make, string model, int year, string color, int seating) : base(make, model, year, color)
        {
            Seating = seating;
        }
    }
}
