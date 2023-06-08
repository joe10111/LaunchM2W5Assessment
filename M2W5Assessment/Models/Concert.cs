using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace M2W5Assessment.Models
{
    public class Concert
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime ShowDate { get; set; }

        public List<Performer> Performers { get; set; }
    }
}
