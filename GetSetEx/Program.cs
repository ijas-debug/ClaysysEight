using System.Runtime.Serialization;

namespace GetSetEx
{
    class Student
    {
        public string Name { set;  get; } //short syntax
        private string gender;
        public Student(string cName, string cGender)  
        {
            Name = cName;
            gender = cGender;

        }
        public string Gender
        {
            get { return gender; }  
            set { 
              if(value == "Male" || value == "Female" || value=="Other")
                {
                    gender = value;
                }
                else
                {
                    throw new ArgumentException("Invalid value supplied");
                }
            }
        }
    }
}