using System;
using System.Text;

public class Program
{
	public static void Main()
	{
		StringBuilder sb = new StringBuilder("Hello World!!");

		for(int i=0; i< sb.Length; i++)
				Console.Write(sb[i]);
		
		StringBuilder sb1 = new StringBuilder("Hello ",50);
		
		sb1.Append("World!!");
		sb1.AppendLine("Hello C#!");
		sb1.AppendLine("This is new line.");
		sb1.AppendFormat("{0:C} ", 22);
		
		
		sb1.Insert(11," My name is Kiet");
		Console.WriteLine(sb1);
	}
}
