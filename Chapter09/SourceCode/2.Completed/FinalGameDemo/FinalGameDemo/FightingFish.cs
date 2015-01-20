﻿
using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Audio;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.GamerServices;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using Microsoft.Xna.Framework.Media;

namespace BookExample
{
    public class FightingFish : PatrolEnemy
    {

        public FightingFish() :
            base("ENEMY_2", Vector2.Zero, new Vector2(kInitFishSize * kEnemyWidth + kEnemyWidth, kInitFishSize * kEnemyWidth + kEnemyWidth), 2, 2, 0)
        {
            mAllowRotate = false;
            mInitFrontDir = Vector2.UnitX;
            mCurrentPatrolType = PatrolType.LeftRight;
            FishSize = kInitFishSize;
            mCurrentEnemyType = EnemyType.FightingFish;
        }

    }
}
