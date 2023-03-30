using System;
namespace StructuralDesignPatterns.ProxyPattern.Example1;

public class RealImage : IImage
{
	private string imageFileName;

	public RealImage(string imageFileName)
	{
		this.imageFileName = imageFileName;
		LoadImage();
	}

	public void Display()
	{
        Console.WriteLine("Display image: " + imageFileName);
    }

	private void LoadImage()
	{
		Console.WriteLine("Load image: " + imageFileName);
	}
}

