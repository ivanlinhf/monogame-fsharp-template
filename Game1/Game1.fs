module Game1

open Microsoft.Xna.Framework
open Microsoft.Xna.Framework.Graphics
open Microsoft.Xna.Framework.Input

type Game1() as x =
    inherit Game()

    let graphics = new GraphicsDeviceManager(x)
    let mutable spriteBatch = Unchecked.defaultof<SpriteBatch>

    do x.Content.RootDirectory <- "Content"
    do x.IsMouseVisible <- true

    override x.Initialize() =
        base.Initialize()

        // TODO: Add your initialization logic here

        ()

    override x.LoadContent() =
        spriteBatch <- new SpriteBatch(x.GraphicsDevice)

        // TODO: use x.Content to load your game content here
        // On Windows you can load any PNG file directly as Texture2D

        // Read more about MonoGame's Content Pipeline: https://docs.monogame.net/articles/tools/mgcb_editor.html
        // or install it with package manager console: [dotnet tool install -g dotnet-mgcb-editor]

        ()

    override x.Update(gameTime) =
        if Keyboard.GetState().IsKeyDown(Keys.Escape) then
            x.Exit()

        // TODO: Add your update logic here

        base.Update(gameTime)

    override x.Draw(gameTime) =
        x.GraphicsDevice.Clear Color.CornflowerBlue

        // TODO: Add your drawing code here

        base.Draw(gameTime)
