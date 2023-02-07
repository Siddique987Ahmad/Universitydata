using System.Linq;
using System.Collections.Generic;
using Microsoft.AspNetCore.Components;
using System.Runtime.CompilerServices;
using Universitydata.enums;

namespace Universitydata
{
    class Student : person
    {
        public string StudentID { get; set; }
        public Department Department { get; set; }

        public int Batch { get; set; }
        public int WarningCount { get; set; }
        public bool isLagecy { get; set; }
        public int EarnedCreditHour { get; set; }
        public float CGPA { get; set; }


    }
}