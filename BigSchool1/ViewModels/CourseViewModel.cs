using BigSchool1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BigSchool1.ViewModels
{
    public class CourseViewModel
    {
        public String Place { get; set; }
        public String Date { get; set; }
        public String Time { get; set; }
        public byte Category { get; set; }
        public IEnumerable<Category> Categories { get; set; }
        public DateTime GetDateTime()
        {
            return DateTime.Parse(string.Format("{0} {1}", Date, Time));
        }
    }
}