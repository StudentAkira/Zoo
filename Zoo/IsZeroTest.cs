using System;

public class IsZeroTest
{
	public IsZeroTest()
	{
	}
	public void CheckZeroTest() 
	{
		Checker ut = new Cheker();
		string result = ut.CheckZero(3);
		if (result == "yes") Console.WriteLine("FAILED");
		else Console.WriteLine("PASSED");
    }
}
