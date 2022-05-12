using System;
					
public class Program
{
	public static void Main()
	{
		int x = 5, y = 10, z = 15;

		int result = x * 3 > y ? x : y > z? y : z;
		
		Console.WriteLine(result);
	}
}