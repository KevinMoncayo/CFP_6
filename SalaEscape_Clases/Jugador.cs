namespace SalaEscape_Clases
{
    public class Jugador
    {
        #region Atributos

        private string nombreJugador;
        private int numeroIntentos;
        //TODO: definir un parámetro que tenga que ver con 

        #endregion


        #region Constructores

        public Jugador(string nombre, int intentos) {

            this.nombreJugador = nombre;
            this.numeroIntentos = intentos;
        }

        #endregion

        #region Propiedades
        /// <summary>
        /// Se define la propiedad nombre del jugador como solo lectura
        /// </summary>
        public string NombreJugador
        {
            get { 
                return nombreJugador;
            }
        }

        /// <summary>
        /// Se define la propiedad numero de intentos como solo lectura, se deja comentado la escritura en caso de necesitarlo.
        /// </summary>
        public int NumeroIntentos 
        {
            get
            {
                return numeroIntentos;
            }
            /*
            set
            {
                numeroIntentos = value;
            }
            */
        }

        #endregion

        #region Metodos

        #endregion


    }
}
