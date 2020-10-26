using Soccer_GPA.GameObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Soccer_GPA
{
    class PlayingState : GameObjectList
    {
        Player thePlayer;

        public PlayingState()
        {
            this.Add(new SpriteGameObject(""));

            thePlayer = new Player();
            this.Add(thePlayer);
        }
    }
}
