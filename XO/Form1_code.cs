using System;
using System.Windows.Forms;

namespace XO
{
  public partial class Form1 : Form
  {
    bool turn = true;
    bool isAuto = false;
    string[,] board = new string[3, 3];

    public Form1()
    {
      InitializeComponent();
      
    }
    private void initBoard()
    {
      for (int i = 0; i < board.GetLength(0); i++)
      {
        for (int j = 0; j < board.GetLength(1); j++)
        {
          board[j, i] = "";
        }
      }
    }

    private void myEventHandler(object sender, EventArgs e)
    {
      Button b = sender as Button;
      string n = b.Name;

      if (turn) b.Text = "O";
      else b.Text = "X";

      b.Enabled = false;

      int x = int.Parse(n[n.Length - 2].ToString());
      int y = int.Parse(n[n.Length - 1].ToString());
      board[x, y] = b.Text;

      tb_btn.Text = "btn ( "+x.ToString()+", " + y.ToString()+" )";

      if (checkMove(x,y))
      {
        // player turn wins
      } else
      {
        turn = !turn;
        if (isAuto)
        {
          // generate computer move
        } else
        {
          // wait for other player's move
          // no code required
        }
      }
    }

    private void Form1_Load(object sender, EventArgs e)
    {
      b_00.Click += myEventHandler;
      b_10.Click += myEventHandler;
      b_20.Click += myEventHandler;
      b_01.Click += myEventHandler;
      b_11.Click += myEventHandler;
      b_21.Click += myEventHandler;
      b_02.Click += myEventHandler;
      b_12.Click += myEventHandler;
      b_22.Click += myEventHandler;

      initBoard();
    }

    private bool checkMove(int x, int y)
    {
      // check if a straight line is done
      return false;
    }
  }
}
