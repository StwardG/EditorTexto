using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace tareaCapaPresentacion
{
    public partial class Paint : Form
    {
        bool pintar = false;
        bool borrar = false;
        bool presionado = false;
        public Paint()
        {
            InitializeComponent();
        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            pintar = false;
            borrar = true;

        }

        private void btnPintar_Click(object sender, EventArgs e)
        {
            pintar = true;
            borrar = false;

        }

        private void Paint_MouseDown(object sender, MouseEventArgs e)
        {
            presionado = true;
        }

        private void Paint_MouseUp(object sender, MouseEventArgs e)
        {
            presionado = false;
        }

        private void Paint_MouseMove(object sender, MouseEventArgs e)
        {
            if((pintar) && (presionado))
            {
                Graphics graphics = CreateGraphics();
                graphics.FillEllipse(new SolidBrush(Color.Black), e.X, e.Y,4, 4);
                graphics.Dispose();
            }
            else if ((borrar) && (presionado))
            {
                Graphics graphics = CreateGraphics();
                graphics.FillEllipse(new SolidBrush(Color.White), e.X, e.Y, 12, 12);
                graphics.Dispose();
            }
        }

        private void coloresBtn_Click(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                label1.BackColor = colorDialog1.Color;
            }
        }

        private void Paint_Load(object sender, EventArgs e)
        {
           
        }

        private void Paint_Paint(object sender, PaintEventArgs e)
        {
           
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
