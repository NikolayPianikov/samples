namespace dotNet40ClassLibrary
{
	using System;

	public class Class1
    {
	    public void Do()
	    {
		    Console.WriteLine($"CurrentDirectory={Environment.CurrentDirectory}");
			Console.WriteLine($"Bitness={IntPtr.Size * 8}");
			Console.WriteLine($"ConfigurationFile={AppDomain.CurrentDomain.SetupInformation.ConfigurationFile}");
		}
    }
}
