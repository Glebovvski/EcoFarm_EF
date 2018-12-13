using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EcoFarm_EF
{
    class Positions
    {
        public Positions()
        {

        }
        public Positions(string positionName, string description)
        {
            PositionName = positionName;
            Description = description;
        }

        public int Id { get; set; }
        public string PositionName { get; set; }
        public string Description { get; set; }
    }
}
