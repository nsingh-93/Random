using System;
using System.Collections.Generic;
					
public class RTSExercise
{
	public void Main()
	{
		List<int> values = new List<int> {1, 3, 6, 2, 78, 3, 9, 8, 7, 132, 45623, 236, 657, 3, 78, 87, 334, 3456 };
		var retDict = aboveBelow(values, 400);
		
		Console.WriteLine("Above = " + retDict["above"] + '\n' + "Below = " + retDict["below"] + '\n');
		
		retDict = aboveBelow(values, 4);
		
		Console.WriteLine("Above = " + retDict["above"] + '\n' + "Below = " + retDict["below"] + '\n');
		
		Console.WriteLine(stringRotation("MyString", 3));
		Console.WriteLine(stringRotation("MyString", 5));		
		Console.WriteLine(stringRotation("MyString", 1));
		Console.WriteLine(stringRotation("MyString", 9));
		Console.WriteLine(stringRotation("MyString", -4));
		Console.WriteLine(stringRotation("MyString", -3));
	}
	
	public Dictionary<string, int> aboveBelow(List<int> values, int compare)
	{
		Dictionary<string, int> retVal = new Dictionary<string, int>();
		
		retVal.Add("above", values.FindAll(x => x > compare).Count);
		retVal.Add("below", values.FindAll(x => x < compare).Count);
		
		return retVal;
	}
	
	public string stringRotation(string input, int rotate)
	{
		int length = input.Length;
		
		if (rotate > length)
			rotate = rotate % length;
		
		if (rotate < 0)
			return input.Substring(Math.Abs(rotate)) + input.Substring(0, Math.Abs(rotate));
		
		return input.Substring(length - rotate) + input.Substring(0, length - rotate);
	}
}