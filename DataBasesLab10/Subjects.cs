using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataBasesLab10
{
    public class Subjects
    {
        public Int16 Id { get; set; }
        public string Subject { get; set; }
        public string Specialization { get; set; }
        public string Subject_Type { get; set; }
        public string Teacher { get; set; }
        public int Semester { get; set; }
        public int Hours { get; set; }
        public int Academic_Group { get; set; }
    }
}
