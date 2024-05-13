namespace XO
{
  partial class Form1
  {
    /// <summary>
    /// Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    /// Clean up any resources being used.
    /// </summary>
    /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    protected override void Dispose(bool disposing)
    {
      if (disposing && (components != null))
      {
        components.Dispose();
      }
      base.Dispose(disposing);
    }

    #region Windows Form Designer generated code

    /// <summary>
    /// Required method for Designer support - do not modify
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rd_2 = new System.Windows.Forms.RadioButton();
            this.b_start = new System.Windows.Forms.Button();
            this.tb_progress = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.Name = "label2";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rd_2);
            this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            resources.ApplyResources(this.groupBox1, "groupBox1");
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.TabStop = false;
            // 
            // rd_2
            // 
            resources.ApplyResources(this.rd_2, "rd_2");
            this.rd_2.Name = "rd_2";
            this.rd_2.UseVisualStyleBackColor = true;
            // 
            // b_start
            // 
            this.b_start.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.b_start.FlatAppearance.BorderSize = 0;
            resources.ApplyResources(this.b_start, "b_start");
            this.b_start.ForeColor = System.Drawing.Color.White;
            this.b_start.Name = "b_start";
            this.b_start.UseVisualStyleBackColor = false;
            this.b_start.Click += new System.EventHandler(this.b_start_Click);
            // 
            // tb_progress
            // 
            resources.ApplyResources(this.tb_progress, "tb_progress");
            this.tb_progress.Name = "tb_progress";
            this.tb_progress.ReadOnly = true;
            // 
            // Form1
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tb_progress);
            this.Controls.Add(this.b_start);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

    }

    #endregion
    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.GroupBox groupBox1;
    private System.Windows.Forms.RadioButton rd_2;
    private System.Windows.Forms.Button b_start;
    private System.Windows.Forms.TextBox tb_progress;
  }
}

