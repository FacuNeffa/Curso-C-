namespace Desafio1
{
    internal class Telefono
    {
        public string Modelo { get; }
        public string Marca { get; }
        public string NumeroTelefonico { get; set; }
        private int codigoOperador;

        public int destino { get; set; }

        public int CodigoOperador
        {
            get { return codigoOperador; }
            set
            {
                if (value >= 1 && value <= 3)
                {
                    codigoOperador = value;
                }
                else
                {
                    codigoOperador = 0;
                }
            }
        }

        public Telefono(string modelo, string marca)
        {
            Modelo = modelo;
            Marca = marca;
        }

        public string Llamar()
        {
            return "Realizando llamada..." + NumeroTelefonico;
        }

        public string Llamar(string contacto)
        {
            return "Llamando a " + contacto;
        }

        public string EnviarMensaje(string mensaje, string destino)
        {
            return "Enviando mensaje a... " + destino + " : "+ mensaje;
        }
    }
}
