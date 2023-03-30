using System;
namespace StructuralDesignPatterns.ProxyPattern.Example1
{
	public class ProxyImage : IImage
	{
		string imageFileName;
		RealImage? realImage;

		public ProxyImage(String imageFileName)
		{
			this.imageFileName = imageFileName;
        }

		public void Display()
		{
			if (realImage == null)
			{
				this.realImage = new RealImage(this.imageFileName);
			}
			this.realImage.Display();
		}
	}
}

