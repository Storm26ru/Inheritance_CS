using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Academy
{
	class Graduate :Student
	{
		public string Subject { get; set; }
		public Graduate
				 (
				  string lastName = "", string firstName = "", uint age = 0,
				  string speciality = "", string group = "", double rating = 0, double attendance = 0,
				  string subject = ""
			): base(lastName,firstName,age,speciality,group,rating,attendance)
		{
			Subject = subject;
			Console.WriteLine($"GConstructor:\t{GetHashCode()}");
		}
		public Graduate(Student student, string subject):base(student)
		{
			Subject = subject;
			Console.WriteLine($"GConstructor:\t{GetHashCode()}");
		}
		/*public Graduate(string[] parameters):base(parameters)
		{
			Subject = parameters[8];
		}*/
		~Graduate()
		{
			Console.WriteLine($"GDestructor:\t{GetHashCode()}");
		}
		public void Print()
		{
			base.Print();
			Console.WriteLine($"{Subject}");
		}
		public override string ToString()
		{
			return base.ToString() + $", {Subject}";
		}
        public override Human Parameters(string[] parameters)
        {
            base.Parameters(parameters);
			Subject = parameters[8];
			return this;
		}
    }
}
