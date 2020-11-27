using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_26_11_20.Models
{
    public class Group
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Year { get; set; }
        public int Course { get; set; }
        public int SpecialtyId { get; set; }
        public Specialty Specialty { get; set; }
    }
}
