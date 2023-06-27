using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace downsizing_machineHMI.Models
{
    public class Student
    {
        public int StudentId { get; set; }

        public string StudentName { get; set; }

        public int StudentAge { get; set; }

        public GenderEnum StudentGender { get; set; }

    }
}
