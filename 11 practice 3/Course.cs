using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11_practice_3
{
    internal class Course
    {
        public Course(string name, Instructor instructor, Textbook textbook) 
        {
            if (name != null)
                Coursename = name;
            else Coursename = "";

            if (instructor != null)
                CourseInstructor = instructor;
            else CourseInstructor = new Instructor();

            if (textbook != null)
                CourseTextbook =textbook;
            else  CourseTextbook = new Textbook();

            

        }
        public string Coursename { get; }
        public Instructor CourseInstructor { get; }
        public Textbook CourseTextbook { get; }
    }
}
