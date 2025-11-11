namespace SalaEscape_Clases
{
    using System;

    public class Correo
    {
        // Atributos privados
        private string direccion;
        private string asunto;
        private string cuerpo;
        private DateTime fecha;
        private bool leido;
        private int id;
        private bool recibido;


        //Constructores

        //por defecto
        public Correo()
        {
            this.direccion = string.Empty;
            this.asunto = string.Empty;
            this.cuerpo = string.Empty;
            this.fecha = DateTime.Now;
            this.leido = false;
            this.id = 0;
            this.recibido = true; // por defecto es recibido
        }

        //con parámetros
        public Correo(string direccion, string asunto, string cuerpo, int id, bool recibido = true, DateTime fecha)
        {
            this.direccion = direccion;
            this.asunto = asunto;
            this.cuerpo = cuerpo;
            this.fecha = fecha;
            this.leido = false;
            this.id = id;
            this.recibido = recibido;
        }

        // Propiedades (getters y setters)
        public string Direccion
        {
            get { return direccion; }
            set { direccion = value; }
        }

        public string Asunto
        {
            get { return asunto; }
            set { asunto = value; }
        }

        public string Cuerpo
        {
            get { return cuerpo; }
            set { cuerpo = value; }
        }

        public DateTime Fecha
        {
            get { return fecha; }
            set { fecha = value; }
        }

        public bool Leido
        {
            get { return leido; }
            set { leido = value; }
        }

        public int ID
        {
            get { return id; }
            set { id = value; }
        }

        public bool Recibido
        {
            get { return recibido; }
            set { recibido = value; }
        }

        // Método para marcar como leído
        public void MarcarComoLeido()
        {
            this.leido = true;
        }
    }
