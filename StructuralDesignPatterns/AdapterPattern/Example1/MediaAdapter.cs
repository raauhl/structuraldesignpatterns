using System;
namespace StructuralDesignPatterns.AdapterPattern.Example1
{
    public class MediaAdapter : MediaPlayer
    {

        AdvanceMediaPlayer? advanceMusicPlayer = null;

        public MediaAdapter(String audioType)
        {
            if (audioType == "vlc")
            {
                advanceMusicPlayer = new VlcPlayer();
            }
            else
            if (audioType == "mp4")
            {
                advanceMusicPlayer = new Mp4Player();
            }
        }

        public void Play(string audioType, string fileName)
        {
            if (this.advanceMusicPlayer == null)
            {
                Console.WriteLine("Invalid format!");
                return;
            }

            if (audioType == "vlc")
            {
                this.advanceMusicPlayer.PlayVlc(fileName);
            }
            else
            if (audioType == "mp4")
            {
                this.advanceMusicPlayer.PlayMp4(fileName);
            }
        }
    }
}

