using System;
namespace StructuralDesignPatterns.ProxyPattern.Example1
{
	public class ProxyExample1
    {
		public ProxyExample1()
		{
		}

		public static void Demo()
		{
			IImage image = new ProxyImage("sunshine.jpg");
			image.Display();
		}
	}
}

