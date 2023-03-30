using System;
namespace StructuralDesignPatterns.AdapterPattern.Example1
{
    public interface MediaPlayer
    {
        public void Play(String audioType, string fileName);
    }
}

