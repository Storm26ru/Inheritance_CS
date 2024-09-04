//#define INHERITANCE_1
//#define INHERITANCE_2
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Academy
{
	class Program
	{
		static readonly string delimetr = "\n-----------------------------------------------\n";
		static void Main(string[] args)
		{
#if INHERITANCE_1
			Human human = new Human("Montana", "Antonio", 25);
			human.Print();
			Console.WriteLine(human);
			Console.WriteLine(delimetr);

			Student student = new Student("Pinkman", "Jessie", 25, "Chemistry", "WW_220", 95, 97);
			student.Print();
			Console.WriteLine(student);
			Console.WriteLine(delimetr);

			Teacher teacher = new Teacher("White", "Walter", 50, "Chemistry", 25);
			teacher.Print();
			Console.WriteLine(teacher);
			Console.WriteLine(delimetr);

			Graduate graduate = new Graduate("Shreder", "Hank", 40, "Criminalistic", "OBN", 50, 80, "How to catch Heisenberg");
			graduate.Print();
			Console.WriteLine(graduate); 
#endif

#if INHERITANCE_2
			Human tommy = new Human("Vercetty", "Tommy", 30);
			Console.WriteLine(tommy);

			Human ken = new Human("Rozenberg", "Ken", 35);
			Console.WriteLine(ken);

			Human diaz = new Human("Diaz", "Ricardo", 50);
			Console.WriteLine(diaz);

			Student s_tommy = new Student(tommy, "Theft", "Vice", 98, 99);
			Console.WriteLine(s_tommy);

			Student s_ken = new Student(ken, "Lawer", "Vice", 42, 35);
			Console.WriteLine(s_ken);

			Graduate g_tommy = new Graduate(s_tommy, "How to make money");
			Console.WriteLine(g_tommy);

			Teacher t_diaz = new Teacher(diaz, "Weapons distribution", 20); 
#endif

			//					Generalization:
			Human[] group = new Human[]
					{
							new Student("Pinkman","Jessie",25,"Chemistry","WW_220",95,97),
							new Teacher("White","Walter",50,"Chemistry",25),
							new Graduate("Schreder","Hank",40,"Criminalistic","OBN",50,80,"How to catch Heisenberg")
					};
			//					Specialization:
			/*for(int i = 0; i<group.Length;i++)
			{
				Console.WriteLine(group[i]);
			}*/
			//					Drive
			/*DriveInfo[] drives = DriveInfo.GetDrives();
			foreach(DriveInfo driveInfo in drives)
			{
				Console.WriteLine($"Name: {driveInfo.Name}");
				Console.WriteLine($"Type: {driveInfo.DriveType}");
				if (driveInfo.IsReady)
				{
					Console.WriteLine($"TotalSize: {driveInfo.TotalSize}");
					Console.WriteLine($"TotalFreeSpace: {driveInfo.TotalFreeSpace}");
					Console.WriteLine($"VolumeLabel: {driveInfo.VolumeLabel}");
				}
			}*/
			//					Directory
			string root = @"E:\TOP\дз\class\Inheritance1\IO\";
			string subDir = @"Academy\Group";
			DirectoryInfo directory = new DirectoryInfo(root);
			if(!directory.Exists)
			{
				directory.Create();
			}
			DirectoryInfo newDir = directory.CreateSubdirectory(subDir);
			Console.WriteLine(newDir.FullName);
			//directory.Delete(true);*/
			//					File
			/*DirectoryInfo directory = new DirectoryInfo(@"C:\");
			FileInfo[] files = directory.GetFiles();
			foreach(FileInfo file in files)
			{
				Console.WriteLine(file.FullName);
			}*/
			FileInfo file = new FileInfo(newDir.FullName + @"\group.txt");
			StreamWriter sw = file.CreateText();
			/*foreach(Human human in group)
			{
				Console.WriteLine(group.ToString());
				sw.WriteLine(group);
				//sw.Close();

			}
			sw.Close();*/
			for(int i=0; i<group.Length; i++)
			{
				sw.WriteLine(group[i]);
			}
			sw.Close();
		}
	}
}
