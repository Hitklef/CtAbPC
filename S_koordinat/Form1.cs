using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace S_koordinat
{
    public partial class CtAbPC : Form
    {
        private const string Path = @"D:\Vitaliy\Work\C#\Hitklef\CtAbPC\S_koordinat\Points.txt";
        MainModal mainModal = new MainModal();

        public CtAbPC()
        {
            InitializeComponent();
        }

        private void buttonOpenTxt_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(Path);
        }

        private async void buttonCalculation_Click(object sender, EventArgs e)
        {
            try
            {
                using (StreamReader TxtReader = new StreamReader(Path, Encoding.Default))
                {
                    string LineForTxt;
                    while ((LineForTxt = await TxtReader.ReadLineAsync()) != null)
                    {
                        string[] Buffer = LineForTxt.Split(';');
                        if (double.TryParse(Buffer[0], out double FirstNumber) && double.TryParse(Buffer[1], out double SecondNumber))
                        {
                            mainModal.SetPoints(new Point(FirstNumber, SecondNumber));
                        }
                    }

                    mainModal.SetResult(AreaCaculation.GetArea(mainModal.GetPoints().ToArray()));
                    double[] res = mainModal.GetResult();
                    labelResultX.Text = "Sx = " + res[0].ToString();
                    labelResultY.Text = "Sy = " + res[1].ToString();
                }
            }
            catch
            {
                MessageBox.Show("Введите три или более точек координат");
            }          
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
