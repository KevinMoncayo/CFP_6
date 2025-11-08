namespace Final2_WF
{
    partial class frmFinal2
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lblMensajeFinal2 = new Label();
            panFinal2 = new Panel();
            btnReintentar = new Button();
            SuspendLayout();
            // 
            // lblMensajeFinal2
            // 
            lblMensajeFinal2.Font = new Font("Consolas", 27.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblMensajeFinal2.Location = new Point(200, 51);
            lblMensajeFinal2.Name = "lblMensajeFinal2";
            lblMensajeFinal2.Size = new Size(433, 223);
            lblMensajeFinal2.TabIndex = 0;
            lblMensajeFinal2.Text = "El tiempo se agotó! No completaste todos los puzzles! La IA se ha borrado...";
            lblMensajeFinal2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panFinal2
            // 
            panFinal2.Location = new Point(452, 296);
            panFinal2.Name = "panFinal2";
            panFinal2.Size = new Size(200, 100);
            panFinal2.TabIndex = 1;
            // 
            // btnReintentar
            // 
            btnReintentar.Location = new Point(245, 323);
            btnReintentar.Name = "btnReintentar";
            btnReintentar.Size = new Size(116, 34);
            btnReintentar.TabIndex = 2;
            btnReintentar.Text = "Volver a intentar?";
            btnReintentar.UseVisualStyleBackColor = true;
            // 
            // frmFinal2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnReintentar);
            Controls.Add(panFinal2);
            Controls.Add(lblMensajeFinal2);
            Name = "frmFinal2";
            Text = "Final 2";
            ResumeLayout(false);
        }

        #endregion

        private Label lblMensajeFinal2;
        private Panel panFinal2;
        private Button btnReintentar;
    }
}
