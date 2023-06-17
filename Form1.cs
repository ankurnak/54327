using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EquationSolver
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();

            panelMenu.BackColor = Color.DarkGray;

            // Оформление panelLogo
            panelLogo.BackColor = Color.LightGray;

            panelLogo.BackgroundImageLayout = ImageLayout.Zoom;

            // Оформление panelTitle
            panelTitle.BackColor = Color.LightGreen;
            panelTitle.ForeColor = Color.White;
            textBox1.Font = new Font("Arial", 40, FontStyle.Bold);
            textBox1.Text = "Linear Equation Solver";
        }
    private void gauss_Click(object sender, EventArgs e)
        {

            FormGauss formGauss = new FormGauss();
            formGauss.Show();
            gauss.BackColor = Color.LightGreen;
        }
        private void gauss_MouseUp(object sender, MouseEventArgs e)
        {
            // Восстановление цвета фона кнопки после отпускания
            gauss.BackColor = Color.Transparent;
        }
        private void jordan_Click(object sender, EventArgs e)
        {
            FormJordan formJordan = new FormJordan();
            formJordan.Show();
            jordan.BackColor = Color.LightGreen;
        }
        private void jordan_MouseUp(object sender, MouseEventArgs e)
        {
            // Восстановление цвета фона кнопки после отпускания
            jordan.BackColor = Color.Transparent;
        }
        private void thomas_Click(object sender, EventArgs e)
        {
            FormThomas formThomas = new FormThomas();
            formThomas.Show();
            thomas.BackColor = Color.LightGreen;
        }
        private void thomas_MouseUp(object sender, MouseEventArgs e)
        {
            // Восстановление цвета фона кнопки после отпускания
            thomas.BackColor = Color.Transparent;
        }
    }
}
