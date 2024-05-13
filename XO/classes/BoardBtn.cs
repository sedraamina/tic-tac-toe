using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;
using System.Windows.Forms;

namespace XO.classes
{
  internal class BoardBtn: Button
  {
    public int X { get; set; }
    public int Y { get; set; }

    public BoardBtn(int x, int y)
    {
      X = x;
      Y = y;
    }

  }
}
