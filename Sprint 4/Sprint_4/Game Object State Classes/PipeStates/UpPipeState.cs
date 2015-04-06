﻿using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Sprint4
{
    class UpPipeState : IPipeState
    {
        IAnimatedSprite sprite;
        ISpriteFactory factory;
        int animTimer = 100;
        
        public UpPipeState()
        {
            factory = new SpriteFactory();
            this.sprite = factory.build(SpriteFactory.sprites.bluePipe);
        }

        public Rectangle GetBoundingBox(Vector2 location)
        {
            return sprite.GetBoundingBox(location);
        }

        public void Update(GameTime gameTime)
        {
            //null
        }
        public void Draw(SpriteBatch spriteBatch, Vector2 location)
        {
            sprite.Draw(spriteBatch, location);
        }
        public void Eat(Mario mario, Pipe pipe)
        {
            Game1.GetInstance().gameState = new PipeTransitionGameState(PipeTransitionGameState.direction.goIn, pipe);
        }
        public void Puke(Mario mario, Pipe pipe)
        {
            Game1.GetInstance().gameState = new PipeTransitionGameState(PipeTransitionGameState.direction.comeOut, pipe);
        }
    }
}