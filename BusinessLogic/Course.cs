using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessLogic
{
    public class Course
    {
        public Course(string courseName)
        {
            
            InstructorName = "STAFF";
            
        }

        /// <summary>
        /// The instructor teaching the course
        /// </summary>
        public string InstructorName { get; set; }

        /// <summary>
        /// The name of the course
        /// </summary>

        public string CourseName
        {
            get { return CourseName; }
            set
            {
                if (CourseName == null)
                {
                    throw new ArgumentNullException(nameof(CourseName));
                }
                classTitle = CourseName;

            }
        }

        public string DefaultInstructor { get; set; }

        private byte numOfCredits;
        private string classTitle;


        /// <summary>
        /// Number of credits for the course
        /// </summary>
        public byte NumberOfCredits { get { return numOfCredits; }
            set
            {
                if (value >= 30 || value == 0)
                {
                    throw new ArgumentException();
                }
                numOfCredits = value;
            }
        }

        public byte NumCredits { get; set; }

        

    }

}
