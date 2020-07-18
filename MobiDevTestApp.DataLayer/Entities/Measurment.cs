using System;
using System.Collections.Generic;
using System.Text;

namespace MobiDevTestApp.DataLayer.Entities
{
    public class Measurment: BaseEntity
    {
        public int Amount { get; set; }

        public ICollection<Ingredient> Ingredients { get; set; }
    }
}
