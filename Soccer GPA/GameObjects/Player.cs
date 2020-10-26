using Microsoft.Xna.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Soccer_GPA.GameObjects
{
    class Player : GameObjectList
    {
        public Player()
        {
            SpriteGameObject player = new SpriteGameObject("characterWhite(1)");

            player.Position = new Vector2(50, 50);
        }
    }
}
