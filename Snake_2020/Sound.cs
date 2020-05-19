using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using WMPLib;

namespace Snake_2020
{
    class Sound
    {
        WindowsMediaPlayer player = new WindowsMediaPlayer();
        private string pathToMedia;

        public Sound(string pathToResources)
        {
            pathToMedia = pathToResources;
        }

        public void Play()
        {
            player.URL = pathToMedia + "Allways.mp3";
            
            player.settings.volume = 30;
            player.controls.play();
            player.settings.setMode("loop", true); // loop mode

        }
        public void PlayEat()
        {
            player.URL = pathToMedia + "Eat.mp3";
            player.settings.volume = 100;
            player.controls.play();
            
        }
        public void Stop()
        {
            player.URL = pathToMedia + "Allways.mp3";
            player.controls.stop();

        }
        public void Play(string songName)
        {
            player.URL = pathToMedia + songName + ".mp3";
            // player.settings.volume = 100;
            player.controls.play();
        }
    }
}
