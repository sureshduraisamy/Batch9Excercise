using System;
namespace GradeSystem
{
	class Grade
	{
		public string studentname;
		public int studentmark;
		public void GetStudentData()
		{
			Console.WriteLine("enter student namme");
			studentname = Console.ReadLine();
			Console.WriteLine("enter machs mark");
			int machs = Convert.ToInt32(Console.ReadLine());
			Console.WriteLine("enter tamil mark");
			int tamil = Convert.ToInt32(Console.ReadLine());
			Console.WriteLine("enter english mark");
			int english = Convert.ToInt32(Console.ReadLine());
			Console.WriteLine("enter social mark");
			int social = Convert.ToInt32(Console.ReadLine());
			Console.WriteLine("enter science mark");
			int science = Convert.ToInt32(Console.ReadLine());
			studentmark = science + social + english + machs + tamil;



		}
		public void  PopulateGrade()
        {
			Console.WriteLine("student name"  + studentname );
			Console.WriteLine("total mark"  + studentmark );
			if(studentmark> 489 && studentmark<501)
            {
				Console.WriteLine("Grade A");

            }
             else if(studentmark>449 && studentmark<490)
            {
				Console.WriteLine("Grade B");

            }
			else if (studentmark>399 && studentmark<450)
			{
				Console.WriteLine("grade c");
       
			}
			
				
			
	
		
			else
            {
				Console.WriteLine("grade d");
            }



       }
	}
}
