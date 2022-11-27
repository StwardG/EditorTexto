namespace tareaCapaPresentacion
{
    partial class Paint
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
            this.btnPintar = new System.Windows.Forms.Button();
            this.btnBorrar = new System.Windows.Forms.Button();
            this.coloresBtn = new System.Windows.Forms.Button();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnPintar
            // 
            this.btnPintar.Location = new System.Drawing.Point(113, 276);
            this.btnPintar.Name = "btnPintar";
            this.btnPintar.Size = new System.Drawing.Size(75, 23);
            this.btnPintar.TabIndex = 0;
            this.btnPintar.Text = "Pintar";
            this.btnPintar.UseVisualStyleBackColor = true;
            this.btnPintar.Click += new System.EventHandler(this.btnPintar_Click);
            // 
            // btnBorrar
            // 
            this.btnBorrar.Location = new System.Drawing.Point(261, 276);
            this.btnBorrar.Name = "btnBorrar";
            this.btnBorrar.Size = new System.Drawing.Size(75, 23);
            this.btnBorrar.TabIndex = 1;
            this.btnBorrar.Text = "Borrar";
            this.btnBorrar.UseVisualStyleBackColor = true;
            this.btnBorrar.Click += new System.EventHandler(this.btnBorrar_Click);
            // 
            // coloresBtn
            // 
            this.coloresBtn.Location = new System.Drawing.Point(378, 12);
            this.coloresBtn.Name = "coloresBtn";
            this.coloresBtn.Size = new System.Drawing.Size(125, 30);
            this.coloresBtn.TabIndex = 2;
            this.coloresBtn.Text = "ChangeBackGround";
            this.coloresBtn.UseVisualStyleBackColor = true;
            this.coloresBtn.Click += new System.EventHandler(this.coloresBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Perpetua Titling MT", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(70, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(292, 29);
            this.label1.TabIndex = 3;
            this.label1.Text = "BIENVENIDO A PAINT";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // Paint
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.HighlightText;
            this.ClientSize = new System.Drawing.Size(515, 343);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.coloresBtn);
            this.Controls.Add(this.btnBorrar);
            this.Controls.Add(this.btnPintar);
            this.ForeColor = System.Drawing.Color.Black;
            this.Name = "Paint";
            this.Text = "Paint";
            this.Load += new System.EventHandler(this.Paint_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Paint_Paint);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Paint_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Paint_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Paint_MouseUp);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btnPintar;
        private Button btnBorrar;
        private Button coloresBtn;
        private ColorDialog colorDialog1;
        private Label label1;
    }
}