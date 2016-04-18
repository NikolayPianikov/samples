namespace dotNet20ClassLibrary
{
	using System;

    public class Class1
    {
	    public void Do()
	    {		    
			Console.WriteLine($"CurrentDirectory={Environment.CurrentDirectory}");
			Console.WriteLine($"Bitness={IntPtr.Size * 8}");
	    }
    }
}
