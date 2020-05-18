using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace win_forms_lab2
{
    public partial class SolutionForm : Form
    {
        bool A = true;
        bool B = true;

        public SolutionForm()
        {
            InitializeComponent();

            AcomboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            AcomboBox.SelectedIndex = 0;

            BcomboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            BcomboBox.SelectedIndex = 0;

            picture1calc.SizeMode = PictureBoxSizeMode.StretchImage;
            picture2calc.SizeMode = PictureBoxSizeMode.StretchImage;
        }

        public void switchedValue() {
            switch (AcomboBox.SelectedIndex)
            {
                case 0:
                    A = true;
                    break;
                case 1:
                    A = false;
                    break;
            }
            switch (BcomboBox.SelectedIndex)
            {
                case 0:
                    B = true;
                    break;
                case 1:
                    B = false;
                    break;
            }
        }

        private void A_calculation_Click(object sender, EventArgs e)
        {
            bool resultA;
            switchedValue();

            resultA = !A && !B || A;
            a_result.Text = resultA.ToString();
            a_result.Visible = true;
        }

        private void B_calculation_Click(object sender, EventArgs e)
        {
            bool resultB;
            switchedValue();

            resultB = B || !A && !(!B);
            b_result.Text = resultB.ToString();
            b_result.Visible = true;
        }

        private void C_calculation_Click(object sender, EventArgs e)
        {
            bool resultC;
            switchedValue();

            resultC = B && !(A && !B);
            c_result.Text = resultC.ToString();
            c_result.Visible = true;
        }

        private void Button1calc_Click(object sender, EventArgs e)
        {
            double a = 3.5;
            double x = 3.4;
            double alfa = 1.0;
            double p = 3.14;
            double ee = 2.718;
            double ch, zn, y;

            ch = Math.Cos(a - p) + Math.Pow(Math.Sin(alfa), 3) + Math.Exp(2 * a) - Math.Sqrt(x + 0.6 * Math.Pow(10, 5));
            zn = 6.5 * Math.Pow(10, 5) * Math.Pow(a, 2) - Math.Log(Math.Abs(a), ee) + 0.43 * Math.Pow(10, -4.5) * x - p;
            y = Math.Log(Math.Abs(ch / zn), 10);

            result_1.Text = y.ToString();
            result_1.Visible = true;
        }

        private void Button2calc_Click(object sender, EventArgs e)
        {
            bool a2 = true;
            bool b2 = true;
            bool c2 = false;
            double x2 = 1.5;
            double y2 = 2.5;
            bool z;

            z = (Math.Pow(x2, 2) + Math.Pow(y2, 2) < 4) && !(a2 && b2 && c2) && (x2 < y2) && (y2 > 0.5);

            result_2.Text = z.ToString();
            result_2.Visible = true;
        }
    }
}
