using System;
namespace StructuralDesignPatterns.AdapterPattern.Example1
{
    public class VlcPlayer : AdvanceMediaPlayer
    {
        public VlcPlayer()
        {
        }

        public void PlayMp4(string fileName)
        {
            throw new NotImplementedException();
        }

        public void PlayVlc(string fileName)
        {
            Console.WriteLine("Playing VLC file: " + fileName);
        }
    }
}

