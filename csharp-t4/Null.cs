using System;
					
public class Program
{
	public static void Main()
	{
		Nullable<int> i = null;
        i = 0

		if (i.HasValue) //HasValue returns true if the object has been assigned a value
			Console.WriteLine(i.Value); // or Console.WriteLine(i)
		else
			Console.WriteLine("Null");
	}
}