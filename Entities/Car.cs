using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example.Iterative.Yield.Entities
{
    public class Car
    {
        public Car(int id, Guid chassis)
        {
            this.Id = id;
            this.Chassis = chassis;
        }

        public int Id { get; set; }
        public Guid Chassis { get; set; }
    }
}
