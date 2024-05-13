using System;
using System.Drawing;
using System.Threading;
using System.Windows.Forms;
using XO.classes;

namespace XO
{
  public partial class Form1 : Form
  {
    bool turn, isAuto, isPlaying, opponentIsPc;
    string s;

    BoardBtn[,] b = new BoardBtn[3,3];

    public Form1()
    {
      InitializeComponent();
    }

    private void Form1_Load(object sender, EventArgs e)
    {
      ResetVars();      
      ShowBoard();
      DisableBoard();
     // rd_1.CheckedChanged += new EventHandler(OpponentChanged);
      rd_2.CheckedChanged += new EventHandler(OpponentChanged);
    }

    private void ShowBoard()
    {
      int x = 320;
      int y = 80;
      int s = 80;

      for (int j=0; j<3; j++)
      {
        for (int i=0; i<3; i++)
        {
          b[i, j] = new BoardBtn(i,j);
          b[i, j].Top = y + (j*s);
          b[i, j].Left = x + (i * s);
          b[i, j].Width = 80;
          b[i, j].Height = 80;
          b[i, j].Font = new Font("Arial Rounded MT Bold", 36);
          b[i, j].BackColor = Color.LightGray;
          b[i, j].FlatStyle = FlatStyle.Flat;
          b[i, j].FlatAppearance.BorderColor = Color.Brown;
          b[i, j].FlatAppearance.BorderSize = 2;
          this.Controls.Add(b[i, j]);
          b[i, j].Click += myEventHandler;
        }
      }
    }

    private void EnableBoard()
    {
      for (int j = 0; j < 3; j++)
      {
        for (int i = 0; i < 3; i++)
        {
          b[i, j].Enabled = true;
        }
      }
    }

    private void DisableBoard()
    {
      for (int j = 0; j < 3; j++)
      {
        for (int i = 0; i < 3; i++)
        {
          b[i, j].Enabled = false;
        }
      }
    }

    private void ClearBoard()
    {
      for (int j = 0; j < 3; j++)
      {
        for (int i = 0; i < 3; i++)
        {
          b[i, j].Text = string.Empty;
          b[i, j].BackColor = Color.LightGray;
        }
      }
    }

    private void ResetVars()
    {
      s = "O";
      turn = true;
      isAuto = false;
      isPlaying = false;
      opponentIsPc = true;
    }

    private void OpponentChanged(object sender, EventArgs e)
    {
      RadioButton rb = sender as RadioButton;
      string rdName = rb.Name.ToString();
      if (rdName == "rd_1")
      {
        if (rb.Checked) opponentIsPc = true;
        else opponentIsPc = false;
      }

      if (rdName == "rd_2")
      {
        if (rb.Checked) opponentIsPc = false;
        else opponentIsPc = true;
      }
      
    }

    private void waitForPlayer(bool p)
    {
      string player;
      if (opponentIsPc)
      {
                player = p ? "اللاعب الأول" : "اللاعب الثاني";
      } 
      else
      {
                player = p ? "اللاعب الأول" : "الجهاز";
      }
      
      tb_progress.Text = "بانتظار حركة " + player;
    }

    private void b_start_Click(object sender, EventArgs e)
    {
      ClearBoard();
      EnableBoard();

      waitForPlayer(turn);

      if (isPlaying)
      {
        isPlaying = false;
        b_start.Text = "إبدأ";
      } else
      {
        isPlaying = true;
        b_start.Text = "إلغاء و إعادة";
      }

    }


    private void myEventHandler(object sender, EventArgs e)
    {
      // clear info box
      tb_progress.Clear();
      BoardBtn btn = sender as BoardBtn;
      btn.Text = s;
      
      btn.Enabled = false;
          

      if (checkMove(btn.X, btn.Y, s))
      {
        string p = turn ? "اللاعب الأول" : opponentIsPc ? "الجهاز" : "اللاعب الثاني";
        tb_progress.Text = p + " يكسب!";
        DisableBoard();
      } else
      {
        int milliseconds = 100;
        Thread.Sleep(milliseconds);

        s = s== "O" ? "X" : "O";
        turn = !turn;
        waitForPlayer(turn);

        if (opponentIsPc)
        {
          // generate computer move
        } 
      }
    }



    private bool checkMove(int x, int y, string s)
    {
      tb_progress.Text = "يتم تسجيل الحركة";

      if (checkY (x, y, s) || checkX(x, y, s)) return true;
      if ((x != 1 || y != 1) && checkDiag(x, y, s)) return true;

      // check if a straight line is done
      return false;
    }

    private bool checkX (int x, int y, string s)
    {
      if (b[0, y].Text == s && b[1, y].Text == s && b[2, y].Text == s)
      {
        setWinBtns(x, y, 0);
        return true;
      }
      return false;
    }

    private bool checkY(int x, int y, string s)
    {
      if (b[x, 0].Text == s && b[x, 1].Text == s && b[x, 2].Text == s)
      {
        setWinBtns(x, y, 1);
        return true;
      }
      return false;
    }

    private bool checkDiag(int x, int y, string s)
    {
      if (b[0, 0].Text == s && b[1, 1].Text == s && b[2, 2].Text == s)
      {
        setWinBtns(x, y, 2);
        return true;
      }

      if (b[2, 0].Text == s && b[1, 1].Text == s && b[0, 2].Text == s)
      {
        setWinBtns(x, y, 3);
        return true;
      }
      return false;
    }

    private void setWinBtns(int x, int y, int l)
    {
      switch (l)
      {
        case 0:
          b[0, y].BackColor = Color.BurlyWood;
          b[1, y].BackColor = Color.BurlyWood;
          b[2, y].BackColor = Color.BurlyWood;
          break;
        case 1:
          b[x, 0].BackColor = Color.BurlyWood;
          b[x, 1].BackColor = Color.BurlyWood;
          b[x, 2].BackColor = Color.BurlyWood;
          break;
        case 2:
          b[0, 0].BackColor = Color.BurlyWood;
          b[1, 1].BackColor = Color.BurlyWood;
          b[2, 2].BackColor = Color.BurlyWood;
          break;
        case 3:
          b[2, 0].BackColor = Color.BurlyWood;
          b[1, 1].BackColor = Color.BurlyWood;
          b[0, 2].BackColor = Color.BurlyWood;
          break;
      }
    }

  }
}
