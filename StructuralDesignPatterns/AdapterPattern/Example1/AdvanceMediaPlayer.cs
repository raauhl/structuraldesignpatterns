using System;
namespace StructuralDesignPatterns.AdapterPattern.Example1
{
    public interface AdvanceMediaPlayer
    {
        public void PlayVlc(String fileName);

        public void PlayMp4(String fileName);
    }
}

