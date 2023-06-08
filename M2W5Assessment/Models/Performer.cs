using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace M2W5Assessment.Models
{
    public class Performer
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string ActDescription { get; set; }
        public List<Concert> Concerts { get; set; }
    }
}
