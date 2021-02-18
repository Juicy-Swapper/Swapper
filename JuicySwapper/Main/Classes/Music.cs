using JuicySwapper.Properties;
using System.IO;
using System.Media;

namespace JuicySwapper.Main.Classes
{
    public class Music
    {   
        public void MusicControl(string Activated)
        {
            Stream str = Resources.ReliefMusic;
            SoundPlayer snd = new SoundPlayer(str);
            if (Activated == "True")
            {              
                snd.PlayLooping();          
            }
            else
            {
                snd.Stop();
            }
        }
    }
}
