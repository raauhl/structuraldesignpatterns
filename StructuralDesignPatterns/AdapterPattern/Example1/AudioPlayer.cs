using System;
namespace StructuralDesignPatterns.AdapterPattern.Example1
{
    public class AudioPlayer : MediaPlayer
    {

        MediaAdapter mediaAdapter;

        public AudioPlayer()
        {

        }

        public void Play(string audioType, string fileName)
        {
            if (audioType == "mp3")
            {
                Console.WriteLine("Playing mp3 file: " + fileName);
            }
            else
            {
                mediaAdapter = new MediaAdapter(audioType);
                mediaAdapter.Play(audioType, fileName);
            }
        }
    }
}

