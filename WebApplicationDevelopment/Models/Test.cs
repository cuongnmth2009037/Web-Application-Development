using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WebApplicationDevelopment.Models
{
    public enum subject
    {
        CoreJava,
        AdvanceJava,
        Programming
    }
    public enum Room
    {
        B10,
        B16,
        B14
    }
    public enum faculty
    {
        JayaLakshmi,
        JohnCarter,
        HienPA
    }
    public class Test
    {
        [Key]
        public int Id { get; set; }
        public subject ExamSubject { get; set; }
        [DisplayFormat(DataFormatString = "{0:HH:mm}", ApplyFormatInEditMode = true)]
        [DataType(DataType.Time)]
        public DateTime StartTime { get; set; }
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}", ApplyFormatInEditMode = true)]
        public DateTime ExamDate { get; set; }
        public int ExamDuration { get; set; }
        public Room ClassRoom { get; set; }
        public faculty Faculty { get; set; }
        public string Status { get; set; }
    }
}