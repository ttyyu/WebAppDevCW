using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace WebAppDevCW.Models
{
    public class Student
    {
        public int StudentId { get; set; }
        public string Name { get; set; }

        [JsonIgnore]

        public List<Enrollment>? Enrollments { get; set; }
    }
}