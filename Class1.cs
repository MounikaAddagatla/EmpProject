using System;

public class EmpStatus
{
	public EmpStatus()
	{
		const int IS_PRESENT = 1;
		public void Attendance()
		{
			Random random = new Random()
				int employeecheck = random.Next(0, 2);
			if (employeecheck == IS_PRESENT)
				Console.WriteLine("Present");
			else
				Console.WriteLine("Absent");
		}
		EmpStatus e = new EmpStatus();
		e.Attendance();
		Console.ReadLine();
	}
}
