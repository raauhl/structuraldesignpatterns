using System;
namespace StructuralDesignPatterns.AdapterPattern.Example1
{
    public class AdapterExample1
    {
        public AdapterExample1()
        {
        }

        public static void Demo()
        {
            AudioPlayer audioPlayer = new AudioPlayer();

            audioPlayer.Play("mp3", "nothing else matters.mp3");
            audioPlayer.Play("mp4", "rap battle.mp4");
            audioPlayer.Play("vlc", "avengers.vlc");
            audioPlayer.Play("avi", "thumbnail.avi");
        }
    }
}

