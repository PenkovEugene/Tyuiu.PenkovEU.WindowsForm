using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Tyuiu.PenkovEU.WindowsForm
{
  public partial class Form1 : Form
  {
    public Form1()
    {
      InitializeComponent();
    }

    private void buttonCalc_Click(object sender, EventArgs e)
    {
      try
      {
        int x = Convert.ToInt32(textBoxX.Text);

        if (radioButtonFirst.Checked)
        {
          double result = (Math.Log10(Math.Abs(Math.Cos(x)))) / (Math.Log10(1 + Math.Pow(x, 2)));
          textBoxResult.Text = Convert.ToString(Math.Round(result, 3));
        }
        else if (radioButtonSecond.Checked)
        {
          double result = Math.Abs(Math.Pow(x, 2) - Math.Pow(x, 3)) - ((Math.Cos(Math.Pow(x, 3)) + 7 * Math.Pow(x, 2)) / (Math.Pow(x, 3) - 15 * x));
          textBoxResult.Text = Convert.ToString(Math.Round(result, 3));
        }
        else
        {
        MessageBox.Show("Вы не выбрали уравнение!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
      }
      catch
      {
        MessageBox.Show("Что-то пошло не так...", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
      }
    }

    private void buttonDev_Click(object sender, EventArgs e)
    {
      MessageBox.Show("Выполнил студент группы НТм-22-1\tПеньков Евгений", "Разработчик", MessageBoxButtons.OK, MessageBoxIcon.Information);

    }

    private void textBoxA_TextChanged(object sender, EventArgs e)
    {

    }

    private void label1_Click(object sender, EventArgs e)
    {

    }

    private void label3_Click(object sender, EventArgs e)
    {

    }

    private void pictureBox3_Click(object sender, EventArgs e)
    {

    }

    private void Form1_Load(object sender, EventArgs e)
    {

    }

    private void label4_Click(object sender, EventArgs e)
    {

    }

    private void panel1_Paint(object sender, PaintEventArgs e)
    {

    }
  }
}
