namespace SalaEscape_WF
{
    public partial class MailForm : Form
    {
        public MailForm()
        {
            InitializeComponent();
        }
        private Button btnEnviados;

        private void InitializeComponent()
        {
            btnEnviados = new Button();
            btnRecibidos = new Button();
            SuspendLayout();
            // 
            // btnEnviados
            // 
            btnEnviados.Location = new Point(41, 35);
            btnEnviados.Name = "btnEnviados";
            btnEnviados.Size = new Size(75, 23);
            btnEnviados.TabIndex = 0;
            btnEnviados.Text = "Enviados";
            btnEnviados.UseVisualStyleBackColor = true;
            // 
            // btnRecibidos
            // 
            btnRecibidos.Location = new Point(122, 35);
            btnRecibidos.Name = "btnRecibidos";
            btnRecibidos.Size = new Size(75, 23);
            btnRecibidos.TabIndex = 1;
            btnRecibidos.Text = "Recibidos";
            btnRecibidos.UseVisualStyleBackColor = true;
            // 
            // MailForm
            // 
            ClientSize = new Size(712, 404);
            Controls.Add(btnRecibidos);
            Controls.Add(btnEnviados);
            Name = "MailForm";
            ResumeLayout(false);

        }
        private Button btnRecibidos;
    }
}
