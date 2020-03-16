﻿using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test.Models
{
  public class GameModel
  {
    public ContentManager ContentManager { get; set; }

    public GraphicsDeviceManager GraphicsDeviceManager { get; set; }

    public SpriteBatch SpriteBatch { get; set; }

    public int ScreenWidth { get; set; }

    public int ScreenHeight { get; set; }

    public GameModel()
    {

    }
  }
}
