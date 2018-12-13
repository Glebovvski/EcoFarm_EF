using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EcoFarm_EF
{
    class Employees
    {
        public Employees()
        {

        }
        public Employees(string name, int age, int positionId)
        {
            Name = name;
            Age = age;
            PositionId = positionId;
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public int PositionId { get; set; }
    }
}
