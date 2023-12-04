namespace Tyuiu.PenkovEU.WindowsForm._2
{
  partial class MyForm2
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
      System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
      System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
      System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MyForm2));
      this.header = new System.Windows.Forms.GroupBox();
      this.buttonDevInfo = new System.Windows.Forms.Button();
      this.buttonCalculate = new System.Windows.Forms.Button();
      this.description = new System.Windows.Forms.Label();
      this.textBox1 = new System.Windows.Forms.TextBox();
      this.finish_step = new System.Windows.Forms.Label();
      this.start_step = new System.Windows.Forms.Label();
      this.numericUpDownEndStep = new System.Windows.Forms.NumericUpDown();
      this.numericUpDownStartStep = new System.Windows.Forms.NumericUpDown();
      this.textBoxResult = new System.Windows.Forms.TextBox();
      this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
      this.pictureBox1 = new System.Windows.Forms.PictureBox();
      this.header.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.numericUpDownEndStep)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.numericUpDownStartStep)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
      this.SuspendLayout();
      // 
      // header
      // 
      this.header.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.header.BackColor = System.Drawing.SystemColors.ActiveCaption;
      this.header.Controls.Add(this.buttonDevInfo);
      this.header.Controls.Add(this.buttonCalculate);
      this.header.Controls.Add(this.description);
      this.header.Controls.Add(this.textBox1);
      this.header.Controls.Add(this.finish_step);
      this.header.Controls.Add(this.start_step);
      this.header.Controls.Add(this.numericUpDownEndStep);
      this.header.Controls.Add(this.numericUpDownStartStep);
      this.header.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      this.header.Location = new System.Drawing.Point(9, 2);
      this.header.Margin = new System.Windows.Forms.Padding(0);
      this.header.Name = "header";
      this.header.Size = new System.Drawing.Size(964, 122);
      this.header.TabIndex = 0;
      this.header.TabStop = false;
      // 
      // buttonDevInfo
      // 
      this.buttonDevInfo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
      this.buttonDevInfo.BackColor = System.Drawing.Color.LightBlue;
      this.buttonDevInfo.Location = new System.Drawing.Point(845, 65);
      this.buttonDevInfo.Name = "buttonDevInfo";
      this.buttonDevInfo.Size = new System.Drawing.Size(108, 32);
      this.buttonDevInfo.TabIndex = 6;
      this.buttonDevInfo.Text = "Developer...";
      this.buttonDevInfo.UseVisualStyleBackColor = false;
      this.buttonDevInfo.Click += new System.EventHandler(this.buttonDevInfo_Click);
      // 
      // buttonCalculate
      // 
      this.buttonCalculate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
      this.buttonCalculate.BackColor = System.Drawing.Color.LightGreen;
      this.buttonCalculate.Location = new System.Drawing.Point(845, 21);
      this.buttonCalculate.Name = "buttonCalculate";
      this.buttonCalculate.Size = new System.Drawing.Size(108, 32);
      this.buttonCalculate.TabIndex = 5;
      this.buttonCalculate.Text = "Calculate";
      this.buttonCalculate.UseVisualStyleBackColor = false;
      this.buttonCalculate.Click += new System.EventHandler(this.buttonCalculate_Click);
      // 
      // description
      // 
      this.description.AutoSize = true;
      this.description.Location = new System.Drawing.Point(12, 10);
      this.description.Name = "description";
      this.description.Size = new System.Drawing.Size(75, 16);
      this.description.TabIndex = 4;
      this.description.Text = "Description";
      // 
      // textBox1
      // 
      this.textBox1.Location = new System.Drawing.Point(12, 29);
      this.textBox1.Multiline = true;
      this.textBox1.Name = "textBox1";
      this.textBox1.Size = new System.Drawing.Size(364, 72);
      this.textBox1.TabIndex = 2;
      this.textBox1.Text = "Для получения результатов и построения графика, пожалуйста, введите начало и коне" +
    "ц шага, и нажмите кнопку \"Calculate\"";
      // 
      // finish_step
      // 
      this.finish_step.AutoSize = true;
      this.finish_step.Location = new System.Drawing.Point(541, 50);
      this.finish_step.Name = "finish_step";
      this.finish_step.Size = new System.Drawing.Size(73, 16);
      this.finish_step.TabIndex = 3;
      this.finish_step.Text = "Finish Step";
      // 
      // start_step
      // 
      this.start_step.AutoSize = true;
      this.start_step.Location = new System.Drawing.Point(427, 50);
      this.start_step.Name = "start_step";
      this.start_step.Size = new System.Drawing.Size(65, 16);
      this.start_step.TabIndex = 2;
      this.start_step.Text = "Start Step";
      // 
      // numericUpDownEndStep
      // 
      this.numericUpDownEndStep.Location = new System.Drawing.Point(528, 75);
      this.numericUpDownEndStep.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
      this.numericUpDownEndStep.Name = "numericUpDownEndStep";
      this.numericUpDownEndStep.Size = new System.Drawing.Size(105, 22);
      this.numericUpDownEndStep.TabIndex = 1;
      // 
      // numericUpDownStartStep
      // 
      this.numericUpDownStartStep.Location = new System.Drawing.Point(405, 75);
      this.numericUpDownStartStep.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
      this.numericUpDownStartStep.Name = "numericUpDownStartStep";
      this.numericUpDownStartStep.Size = new System.Drawing.Size(105, 22);
      this.numericUpDownStartStep.TabIndex = 0;
      // 
      // textBoxResult
      // 
      this.textBoxResult.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
      this.textBoxResult.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append;
      this.textBoxResult.BackColor = System.Drawing.SystemColors.ControlLight;
      this.textBoxResult.BorderStyle = System.Windows.Forms.BorderStyle.None;
      this.textBoxResult.Location = new System.Drawing.Point(12, 142);
      this.textBoxResult.Multiline = true;
      this.textBoxResult.Name = "textBoxResult";
      this.textBoxResult.ReadOnly = true;
      this.textBoxResult.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
      this.textBoxResult.Size = new System.Drawing.Size(281, 244);
      this.textBoxResult.TabIndex = 1;
      // 
      // chart1
      // 
      this.chart1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      chartArea1.Name = "ChartArea1";
      this.chart1.ChartAreas.Add(chartArea1);
      legend1.Name = "Legend1";
      this.chart1.Legends.Add(legend1);
      this.chart1.Location = new System.Drawing.Point(299, 142);
      this.chart1.Name = "chart1";
      series1.ChartArea = "ChartArea1";
      series1.Legend = "Legend1";
      series1.Name = "Series1";
      this.chart1.Series.Add(series1);
      this.chart1.Size = new System.Drawing.Size(671, 349);
      this.chart1.TabIndex = 2;
      this.chart1.Text = "chart1";
      // 
      // pictureBox1
      // 
      this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
      this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
      this.pictureBox1.Location = new System.Drawing.Point(12, 392);
      this.pictureBox1.Name = "pictureBox1";
      this.pictureBox1.Size = new System.Drawing.Size(261, 99);
      this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
      this.pictureBox1.TabIndex = 3;
      this.pictureBox1.TabStop = false;
      // 
      // MyForm2
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(982, 503);
      this.Controls.Add(this.pictureBox1);
      this.Controls.Add(this.chart1);
      this.Controls.Add(this.textBoxResult);
      this.Controls.Add(this.header);
      this.MinimumSize = new System.Drawing.Size(820, 500);
      this.Name = "MyForm2";
      this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
      this.Text = "MyForm2";
      this.header.ResumeLayout(false);
      this.header.PerformLayout();
      ((System.ComponentModel.ISupportInitialize)(this.numericUpDownEndStep)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.numericUpDownStartStep)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.GroupBox header;
    private System.Windows.Forms.TextBox textBoxResult;
    private System.Windows.Forms.NumericUpDown numericUpDownEndStep;
    private System.Windows.Forms.NumericUpDown numericUpDownStartStep;
    private System.Windows.Forms.Label start_step;
    private System.Windows.Forms.Label description;
    private System.Windows.Forms.TextBox textBox1;
    private System.Windows.Forms.Label finish_step;
    private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
    private System.Windows.Forms.Button buttonCalculate;
    private System.Windows.Forms.Button buttonDevInfo;
    private System.Windows.Forms.PictureBox pictureBox1;
  }
}

