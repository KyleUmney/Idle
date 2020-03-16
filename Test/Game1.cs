using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using System;
using System.Collections.Generic;
using System.IO;
using System.Xml.Serialization;
using Test.Models;
using Test.States;
using Test.Units;

namespace Test
{
  /// <summary>
  /// This is the main type for your game.
  /// </summary>
  public class Game1 : Game
  {
    GraphicsDeviceManager graphics;
    SpriteBatch spriteBatch;

    private State _currentState;

    private State _nextState;

    public GameModel gameModel;

    public void ChangeState(State state)
    {
      _nextState = state;
    }


    public Game1()
    {
      graphics = new GraphicsDeviceManager(this);
      Content.RootDirectory = "Content";
    }

    /// <summary>
    /// Allows the game to perform any initialization it needs to before starting to run.
    /// This is where it can query for any required services and load any non-graphic
    /// related content.  Calling base.Initialize will enumerate through any components
    /// and initialize them as well.
    /// </summary>
    protected override void Initialize()
    {
      // TODO: Add your initialization logic here
      IsMouseVisible = true;
      graphics.PreferredBackBufferWidth = 1280;
      graphics.PreferredBackBufferHeight = 720;

      graphics.ApplyChanges();

      base.Initialize();
    }

    /// <summary>
    /// LoadContent will be called once per game and is the place to load
    /// all of your content.
    /// </summary>
    protected override void LoadContent()
    {
      // Create a new SpriteBatch, which can be used to draw textures.
      spriteBatch = new SpriteBatch(GraphicsDevice);
      gameModel = new GameModel()
      {
        ScreenHeight = graphics.PreferredBackBufferHeight,
        ScreenWidth = graphics.PreferredBackBufferWidth,
        ContentManager = Content,
        GraphicsDeviceManager = graphics,
        SpriteBatch = spriteBatch,
      };

      _currentState = new GameState(this, gameModel);

      _currentState.LoadContent();
    }

    /// <summary>
    /// UnloadContent will be called once per game and is the place to unload
    /// game-specific content.
    /// </summary>
    protected override void UnloadContent()
    {
      // TODO: Unload any non ContentManager content here
    }

    /// <summary>
    /// Allows the game to run logic such as updating the world,
    /// checking for collisions, gathering input, and playing audio.
    /// </summary>
    /// <param name="gameTime">Provides a snapshot of timing values.</param>
    protected override void Update(GameTime gameTime)
    {
      if (_nextState != null)
      {
        _currentState = _nextState;
        _currentState.LoadContent();

        _nextState = null;
      }

      _currentState.Update(gameTime);

      _currentState.PostUpdate(gameTime);

      base.Update(gameTime);
    }

    /// <summary>
    /// This is called when the game should draw itself.
    /// </summary>
    /// <param name="gameTime">Provides a snapshot of timing values.</param>
    protected override void Draw(GameTime gameTime)
    {
      GraphicsDevice.Clear(Color.CornflowerBlue);

      _currentState.Draw(gameTime, spriteBatch);

      base.Draw(gameTime);
    }
  }
}
