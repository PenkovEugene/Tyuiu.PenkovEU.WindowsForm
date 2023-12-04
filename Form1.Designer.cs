namespace Tyuiu.PenkovEU.WindowsForm
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
      this.textBoxX = new System.Windows.Forms.TextBox();
      this.label1 = new System.Windows.Forms.Label();
      this.pictureBox1 = new System.Windows.Forms.PictureBox();
      this.pictureBox3 = new System.Windows.Forms.PictureBox();
      this.textBoxResult = new System.Windows.Forms.TextBox();
      this.label2 = new System.Windows.Forms.Label();
      this.radioButtonFirst = new System.Windows.Forms.RadioButton();
      this.radioButtonSecond = new System.Windows.Forms.RadioButton();
      this.panel1 = new System.Windows.Forms.Panel();
      this.label4 = new System.Windows.Forms.Label();
      this.buttonCalc = new System.Windows.Forms.Button();
      this.groupBox1 = new System.Windows.Forms.GroupBox();
      this.buttonDev = new System.Windows.Forms.Button();
      ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
      this.panel1.SuspendLayout();
      this.SuspendLayout();
      // 
      // textBoxX
      // 
      this.textBoxX.AccessibleName = "";
      this.textBoxX.Font = new System.Drawing.Font("Bookman Old Style", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
      this.textBoxX.Location = new System.Drawing.Point(148, 192);
      this.textBoxX.Multiline = true;
      this.textBoxX.Name = "textBoxX";
      this.textBoxX.Size = new System.Drawing.Size(120, 33);
      this.textBoxX.TabIndex = 0;
      this.textBoxX.TextChanged += new System.EventHandler(this.textBoxA_TextChanged);
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.BackColor = System.Drawing.SystemColors.ActiveBorder;
      this.label1.Location = new System.Drawing.Point(38, 201);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(92, 18);
      this.label1.TabIndex = 1;
      this.label1.Text = "Значение X:";
      this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
      this.label1.Click += new System.EventHandler(this.label1_Click);
      // 
      // pictureBox1
      // 
      this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
      this.pictureBox1.Location = new System.Drawing.Point(463, 173);
      this.pictureBox1.Name = "pictureBox1";
      this.pictureBox1.Size = new System.Drawing.Size(154, 65);
      this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
      this.pictureBox1.TabIndex = 2;
      this.pictureBox1.TabStop = false;
      // 
      // pictureBox3
      // 
      this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
      this.pictureBox3.Location = new System.Drawing.Point(463, 295);
      this.pictureBox3.Name = "pictureBox3";
      this.pictureBox3.Size = new System.Drawing.Size(290, 65);
      this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
      this.pictureBox3.TabIndex = 4;
      this.pictureBox3.TabStop = false;
      this.pictureBox3.Click += new System.EventHandler(this.pictureBox3_Click);
      // 
      // textBoxResult
      // 
      this.textBoxResult.AccessibleName = "";
      this.textBoxResult.Font = new System.Drawing.Font("Bookman Old Style", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
      this.textBoxResult.Location = new System.Drawing.Point(148, 326);
      this.textBoxResult.Multiline = true;
      this.textBoxResult.Name = "textBoxResult";
      this.textBoxResult.ReadOnly = true;
      this.textBoxResult.Size = new System.Drawing.Size(120, 33);
      this.textBoxResult.TabIndex = 5;
      // 
      // label2
      // 
      this.label2.AutoSize = true;
      this.label2.BackColor = System.Drawing.SystemColors.ActiveBorder;
      this.label2.Location = new System.Drawing.Point(38, 335);
      this.label2.Name = "label2";
      this.label2.Size = new System.Drawing.Size(105, 18);
      this.label2.TabIndex = 6;
      this.label2.Text = "Результат: Z = ";
      this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
      // 
      // radioButtonFirst
      // 
      this.radioButtonFirst.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.radioButtonFirst.AutoSize = true;
      this.radioButtonFirst.Location = new System.Drawing.Point(440, 198);
      this.radioButtonFirst.Name = "radioButtonFirst";
      this.radioButtonFirst.Size = new System.Drawing.Size(17, 16);
      this.radioButtonFirst.TabIndex = 8;
      this.radioButtonFirst.TabStop = true;
      this.radioButtonFirst.UseVisualStyleBackColor = true;
      // 
      // radioButtonSecond
      // 
      this.radioButtonSecond.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.radioButtonSecond.AutoSize = true;
      this.radioButtonSecond.Location = new System.Drawing.Point(440, 318);
      this.radioButtonSecond.Name = "radioButtonSecond";
      this.radioButtonSecond.Size = new System.Drawing.Size(17, 16);
      this.radioButtonSecond.TabIndex = 9;
      this.radioButtonSecond.TabStop = true;
      this.radioButtonSecond.UseVisualStyleBackColor = true;
      // 
      // panel1
      // 
      this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
      this.panel1.Controls.Add(this.label4);
      this.panel1.Location = new System.Drawing.Point(12, 15);
      this.panel1.Name = "panel1";
      this.panel1.Size = new System.Drawing.Size(865, 125);
      this.panel1.TabIndex = 10;
      this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
      // 
      // label4
      // 
      this.label4.AutoSize = true;
      this.label4.Location = new System.Drawing.Point(16, 18);
      this.label4.Name = "label4";
      this.label4.Size = new System.Drawing.Size(456, 90);
      this.label4.TabIndex = 11;
      this.label4.Text = "В данном окне вы можете посчитать значения по двум формулам.\r\nПожалуйста,\r\n1. Вве" +
    "дите необходимые данные\r\n2. Выберите формулу\r\n3. Нажмите кнопку \"Посчитать\"";
      this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
      this.label4.Click += new System.EventHandler(this.label4_Click);
      // 
      // buttonCalc
      // 
      this.buttonCalc.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
      this.buttonCalc.BackColor = System.Drawing.Color.Thistle;
      this.buttonCalc.Cursor = System.Windows.Forms.Cursors.Hand;
      this.buttonCalc.Location = new System.Drawing.Point(758, 473);
      this.buttonCalc.Name = "buttonCalc";
      this.buttonCalc.Size = new System.Drawing.Size(119, 36);
      this.buttonCalc.TabIndex = 11;
      this.buttonCalc.Text = "Посчитать";
      this.buttonCalc.UseVisualStyleBackColor = false;
      this.buttonCalc.Click += new System.EventHandler(this.buttonCalc_Click);
      // 
      // groupBox1
      // 
      this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
      this.groupBox1.BackColor = System.Drawing.SystemColors.ActiveBorder;
      this.groupBox1.Location = new System.Drawing.Point(12, 126);
      this.groupBox1.Name = "groupBox1";
      this.groupBox1.Size = new System.Drawing.Size(422, 384);
      this.groupBox1.TabIndex = 12;
      this.groupBox1.TabStop = false;
      // 
      // buttonDev
      // 
      this.buttonDev.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
      this.buttonDev.BackColor = System.Drawing.SystemColors.Info;
      this.buttonDev.Location = new System.Drawing.Point(623, 473);
      this.buttonDev.Name = "buttonDev";
      this.buttonDev.Size = new System.Drawing.Size(113, 36);
      this.buttonDev.TabIndex = 13;
      this.buttonDev.Text = "Выполнил...";
      this.buttonDev.UseVisualStyleBackColor = false;
      this.buttonDev.Click += new System.EventHandler(this.buttonDev_Click);
      // 
      // Form1
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 18F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.BackColor = System.Drawing.Color.Gainsboro;
      this.ClientSize = new System.Drawing.Size(889, 522);
      this.Controls.Add(this.buttonDev);
      this.Controls.Add(this.buttonCalc);
      this.Controls.Add(this.panel1);
      this.Controls.Add(this.radioButtonSecond);
      this.Controls.Add(this.radioButtonFirst);
      this.Controls.Add(this.label2);
      this.Controls.Add(this.textBoxResult);
      this.Controls.Add(this.pictureBox3);
      this.Controls.Add(this.pictureBox1);
      this.Controls.Add(this.label1);
      this.Controls.Add(this.textBoxX);
      this.Controls.Add(this.groupBox1);
      this.Font = new System.Drawing.Font("Bookman Old Style", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
      this.MinimizeBox = false;
      this.MinimumSize = new System.Drawing.Size(850, 450);
      this.Name = "Form1";
      this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
      this.Text = "MyForm";
      this.Load += new System.EventHandler(this.Form1_Load);
      ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
      this.panel1.ResumeLayout(false);
      this.panel1.PerformLayout();
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.TextBox textBoxX;
    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.PictureBox pictureBox1;
    private System.Windows.Forms.PictureBox pictureBox3;
    private System.Windows.Forms.TextBox textBoxResult;
    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.RadioButton radioButtonFirst;
    private System.Windows.Forms.RadioButton radioButtonSecond;
    private System.Windows.Forms.Panel panel1;
    private System.Windows.Forms.Label label4;
    private System.Windows.Forms.Button buttonCalc;
    private System.Windows.Forms.GroupBox groupBox1;
    private System.Windows.Forms.Button buttonDev;
  }
}

