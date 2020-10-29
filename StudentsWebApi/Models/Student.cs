using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace StudentsWebApi.Models
{
    // this class will be used to create table student in the db
    public class Student
    {
        // using data annotations to create a PK
        [Key]

        public int StdID { get; set; }
        // Student name field
        public string StdName { get; set; }
        // Student age fied
        public int StdAge { get; set; }
        // Student email field
        public string StdEmail { get; set; }
        // Student phone field
        public string StdPhone { get; set; }

    }
}
