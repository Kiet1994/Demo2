// ta dùng từ khóa KeyValuePair<,>  để làm đại diện cho một phần tử trong dictionary
using System;
using System.Collections.Generic;
using System.Linq;

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
        Console.WriteLine(cities["UK"]); //prints value of UK key
		Console.WriteLine(cities["USA"]);//prints value of USA key
		//Console.WriteLine(cities["France"]); // run-time exception: Key does not exist

		//use ContainsKey() to check for an unknown key
		if(cities.ContainsKey("France")){  
			Console.WriteLine(cities["France"]);
		}

		//use TryGetValue() to get a value of unknown key
		string result;

		if(cities.TryGetValue("France", out result))
		{
			Console.WriteLine(result);
		}

		Console.WriteLine("---access elements using for loop---");
		//use ElementAt() to retrieve key-value pair using index
		for (int i = 0; i < cities.Count; i++)
		{
			Console.WriteLine("Key: {0}, Value: {1}", 
													cities.ElementAt(i).Key, 
													cities.ElementAt(i).Value);
		}
        cities.Clear(); //deletes all elements
		
		Console.WriteLine("Total Elements after Clear(): {0}", cities.Count);
		
	}
}