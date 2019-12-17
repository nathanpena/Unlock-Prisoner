using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace Unlock_Prison.Models
{
    class Course
    {
        public string Ada { get; set; }
        public string Bda { get; set; }
        public string Cda { get; set; }
        public string Dda { get; set; }
        public string CourseLevel { get; set; }
        public int CourseNumber { get; set; }
        public bool IsAvailable { get; set; }

        public override string ToString()
        {
            return $"Ada = {this.Ada}\n" +
                   $"Bda = {this.Bda}\n" +
                   $"Cda = {this.Cda}\n" +
                   $"Dda = {this.Dda}\n" +
                   $"CourseLevel = {this.CourseLevel}\n" +
                   $"CourseNumber = {this.CourseNumber.ToString()}\n" +
                   $"IsAvailable = {this.IsAvailable.ToString()}\n";
        }
    }
}
