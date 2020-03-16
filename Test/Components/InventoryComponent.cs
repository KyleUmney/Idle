using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test.Components
{
  public class InventoryComponent
  {
    public Texture2D Texture {get;set;}

    public Rectangle Rectangle { get; set; }

    public Vector2 Pos { get; set; }

    public int Number { get; set; }

    public SlotComponent Slot { get; set; }
}
}
