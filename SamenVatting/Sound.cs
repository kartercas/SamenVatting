using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using Microsoft.Xna.Framework.Media;
using Microsoft.Xna.Framework.Audio;

namespace SamenVatting
{
    class Sound
    {
        public void sounds()
        {
            //bijna het zelfde af de sprites 
            SoundEffect _song;
            //moet in de load content
            //  _song = Content.Load<SoundEffect>(@"Sounds/BackgroundMusic"); 
            _song = null;
            SoundEffectInstance soundEffectInstance = _song.CreateInstance(); 
            soundEffectInstance.Volume = 0.5f;
            soundEffectInstance.Pan = -0.5f;
            soundEffectInstance.Pitch = 0.5f;
            soundEffectInstance.IsLooped = true;
            soundEffectInstance.Play();
        }
    }
}
