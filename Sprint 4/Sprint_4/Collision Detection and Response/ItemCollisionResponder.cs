﻿using Microsoft.Xna.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Sprint4
{
    public class ItemCollisionResponder
    {
        ISpriteFactory factory = new SpriteFactory();
        Game1 game;
        public ItemCollisionResponder(Game1 game)
        {
            this.game = game;
        }
        public void MarioItemCollide(ICollectable item, Mario mario)
        {
            if (item.GetType().Equals(new Star(item.position).GetType()))
            {
                mario.isStar = true;
                SoundManager.PlaySong(SoundManager.songs.star);
            }
            if (item.GetType().Equals(new SuperMushroom(item.position).GetType()))
            {
                mario.MakeBigMario();
                SoundManager.grow.Play();
            }
            if (item.GetType().Equals(new FireFlower(item.position).GetType()))
            {
                mario.MakeFireMario();
                SoundManager.grow.Play();
            }
            if (item.GetType().Equals(new Coin(item.position).GetType()))
            {
                SoundManager.coinCollect.Play();
                game.coins++;
            }
            if (item.GetType().Equals(new OneUpMushroom(item.position).GetType()))
            {
                SoundManager.oneUp.Play();
                game.lives++;
            }
        }
    }
}

