// ta dùng từ khóa KeyValuePair<,>  để làm đại diện cho một phần tử trong dictionary
using System;
using System.Collections.Generic;

public class Program
{
	public static void Main()
	{
		IDictionary<int, string> numberNames = new Dictionary<int, string>();
		numberNames.Add(1,"One"); //adding key/value using the Add() method
		numberNames.Add(3,"Three");
		numberNames.Add(2,"Two");
		
		foreach(KeyValuePair<int, string> kvp in numberNames)
			Console.WriteLine("Key: {0}, Value: {1}", kvp.Key, kvp.Value);
		
		//creating a dictionary using collection-initializer syntax
		var cities = new Dictionary<string, string>(){
			{"UK","London, Manchester, Birmingham"},
			{"USA","Chicago, New York, Washington"},
			{"India","Mumbai, New Delhi, Pune"}
		};
		
		foreach(var kvp in cities)
			Console.WriteLine("Key: {0}, Value: {1}", kvp.Key, kvp.Value);
		
	}
}