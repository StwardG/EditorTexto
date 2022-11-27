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
    public partial class editorTexto : Form
    {

        public editorTexto()
        {
            InitializeComponent();
        }

        private void Abrir_Click(object sender, EventArgs e)
        {
            string r;
            openFileDialog1.ShowDialog();
            System.IO.StreamReader ar = new System.IO.StreamReader(openFileDialog1.FileName);
            r = ar.ReadToEnd();
            richTextBox1.Text = r.ToString();
        }

        private void Guardar_Click(object sender, EventArgs e)
        {
            saveFileDialog1.FileName = "Sin titulo.txt";
            var guardar = saveFileDialog1.ShowDialog();
            if(guardar == DialogResult.OK)
            {
                using(var guardar_archivo = new System.IO.StreamWriter(saveFileDialog1.FileName ))
                {
                    guardar_archivo.WriteLine(richTextBox1.Text);
                }
            }
        }

        private void Cerrar_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void Atras_Click(object sender, EventArgs e)
        {
            richTextBox1.Undo();
        }

        private void Adelante_Click(object sender, EventArgs e)
        {
            richTextBox1.Redo();
        }

        private void Copiar_Click(object sender, EventArgs e)
        {
            richTextBox1.Copy();
        }

        private void Cortar_Click(object sender, EventArgs e)
        {
            richTextBox1.Cut();
        }

        private void Pegar_Click(object sender, EventArgs e)
        {
            richTextBox1.Paste();
        }

        private void seleccionarTodo_Click(object sender, EventArgs e)
        {
            richTextBox1.SelectAll();
        }

        private void eliminarTodo_Click(object sender, EventArgs e)
        {
            richTextBox1.Clear();
        }

        private void color_Click(object sender, EventArgs e)
        {
            var clr = colorDialog1.ShowDialog();
            if(clr == DialogResult.OK)
            {
                richTextBox1.ForeColor = colorDialog1.Color;
            }
        }

        private void formato_Click(object sender, EventArgs e)
        {
            var format = fontDialog1.ShowDialog();
            if (format == DialogResult.OK)
            {
                richTextBox1.Font = fontDialog1.Font;
            }
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {

        }

        private void Seleccionar_tamaño(object sender, EventArgs e)
        {
            if(richTextBox1.SelectedText != "")
            {
                richTextBox1.SelectionFont = new Font(richTextBox1.Font.SystemFontName, 
                float.Parse(toolStripComboBox1.SelectedItem.ToString()), richTextBox1.Font.Style)
                {

                };
            }
        }

        private void toolStripComboBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
