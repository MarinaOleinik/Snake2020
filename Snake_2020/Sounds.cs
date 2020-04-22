using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media;

namespace Snake_2020
{
    class Sounds
    {
        //string file;
        public Sounds()
        {

        }
        
        public void PlayAllways()
        {
            var player = new System.Windows.Media.MediaPlayer();

           // player.Open(new Uri(@"C:\Users\marina.oleinik\source\repos\Snake_2020\Snake_2020\Allways.mp3", UriKind.Relative));
            player.Open(new Uri("Allways.mp3", UriKind.Relative));
            player.Volume = 100;
            player.Play();
        }

    }
}
