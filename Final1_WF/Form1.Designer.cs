namespace Final1_WF
{
    partial class Form1
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
            label1 = new Label();
            panScore = new Panel();
            btnReintentar = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Font = new Font("Consolas", 36F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(154, 63);
            label1.Name = "label1";
            label1.Size = new Size(522, 178);
            label1.TabIndex = 0;
            label1.Text = "Contraseña correcta! Has liberado a la I.A.";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panScore
            // 
            panScore.BackColor = Color.White;
            panScore.Location = new Point(454, 303);
            panScore.Name = "panScore";
            panScore.Size = new Size(163, 74);
            panScore.TabIndex = 1;
            // 
            // btnReintentar
            // 
            btnReintentar.Location = new Point(235, 318);
            btnReintentar.Name = "btnReintentar";
            btnReintentar.Size = new Size(117, 39);
            btnReintentar.TabIndex = 2;
            btnReintentar.Text = "Volver a intentar?";
            btnReintentar.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnReintentar);
            Controls.Add(panScore);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private Panel panScore;
        private Button btnReintentar;
    }
}
