using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test.Components
{
 public class SlotComponent
  {
    public string ItemName { get; set; }
    public Texture2D Texture { get; set; }

    public Rectangle SlotRectangle { get; set; }
  }
}
