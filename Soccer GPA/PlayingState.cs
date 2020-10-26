using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Soccer_GPA
{
    class PlayingState : GameObjectList
    {
        GameObjectList players;

        public PlayingState()
        {
            this.Add(new SpriteGameObject(""));

            players = new GameObjectList();
            this.Add(players);
        }
    }
}
