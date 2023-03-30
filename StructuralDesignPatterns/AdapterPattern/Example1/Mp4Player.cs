using System;
namespace StructuralDesignPatterns.AdapterPattern.Example1
{
    public class Mp4Player : AdvanceMediaPlayer
    {
        public Mp4Player()
        {
        }

        public void PlayMp4(string fileName)
        {
            Console.WriteLine("Playing Mp4 file: " + fileName);
        }

        public void PlayVlc(string fileName)
        {
            throw new NotImplementedException();
        }
    }
}

