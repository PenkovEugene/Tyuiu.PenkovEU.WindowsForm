using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace Tyuiu.PenkovEU.WindowsForm._2
{
  public partial class MyForm2 : Form
  {
    public MyForm2()
    {
      InitializeComponent();
    }

    public double[] GetMassFunction(int start, int finish)
    {
      double[] valueArray;
      int len = (finish - start) + 1;
      valueArray = new double[len];
      double y;
      int count = 0;
      for (int x = start; x <= finish; x++)
      {
        y = Math.Round((Math.Pow(((Math.Pow(x, 2) + (1 / Math.Pow(x, 2)))), x) - 12 * Math.Pow(x, 2)), 2);
        valueArray[count] = y;
        if (x == 0)
        {
          valueArray[count] = 0;
        }
        count++;
      }

      return valueArray;
    }

    private void buttonCalculate_Click(object sender, EventArgs e)
    {
      try
      {
        int start = Convert.ToInt32(numericUpDownStartStep.Text);
        int finish = Convert.ToInt32(numericUpDownEndStep.Text);


        double[] valueArray = GetMassFunction(start, finish);

        textBoxResult.Clear();


        for (int i = 0; i < valueArray.Length; i++)
        {
          textBoxResult.AppendText($"{valueArray[i]}\r\n");
        }

        chart1.Series.Clear();

        Series series = new Series("Graph");
        series.ChartType = SeriesChartType.Line;

        for (int i = 0; i < valueArray.Length; i++)
        {
          series.Points.AddXY(i + start, valueArray[i]);
        }

        chart1.Series.Add(series);

      }
      catch 
      {
        MessageBox.Show("Что-то пошло не так...", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
      }
    }

    private void buttonDevInfo_Click(object sender, EventArgs e)
    {
      MessageBox.Show("Выполнил студент группы НТм-22-1\tПеньков Евгений", "Разработчик", MessageBoxButtons.OK, MessageBoxIcon.Information);
    }
  }
}
