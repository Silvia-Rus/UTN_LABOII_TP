using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Entidades
{
    public class Procesador
    {
        static private List<Documento> documentos;
        private string nombre;

        /// <summary>
        /// Constructor que inicia la lista.
        /// </summary>
        private Procesador()
        {
            documentos = new List<Documento>();
        }

        /// <summary>
        /// Constructor que le añade nombre al objeto.
        /// </summary>
        /// <param name="nombre"></param>
        public Procesador(string nombre) : this()
        {
            this.nombre = nombre;
        }

        /// <summary>
        /// Con los documentos recién cargados, se distribuyen a la guillotina si procede o se llevan directamente a escanear.
        /// </summary>
        /// <param name="documento">Documento a distribuir.</param>
        /// <returns>Devuelve verdadero si el documento cumple las condiciones para ser distribuido.</returns>
        public bool Distribuir(Documento documento)
        {
            bool retorno = false;

            if(documento.FaseProceso == PasosProceso.introducido)
            {              
                if(documento.EstadoEncuadernacion == Encuadernacion.paraGuillotinar)
                {
                    documento.FaseProceso = PasosProceso.paraGuilotinar;
                }
                else if(documento.EstadoEncuadernacion == Encuadernacion.hojasSueltas || documento.EstadoEncuadernacion == Encuadernacion.encuadernado)
                {
                    documento.FaseProceso = PasosProceso.paraEscanear;
                }

                retorno = true;          
            }
            /*else
            {
                NOOOOOO
            }*/         

            return retorno;
        }
        
        /// <summary>
        /// Da por guilloltinado el documento que pasa por parámtero  y lo pasa a la fase de escaneo previa validación de que está para guillotinar.
        /// </summary>
        /// <param name="documento">Documento a guillotinar.</param>
        /// <returns>Verdadero si el documento estaba para guillotinar. Falso si no.</returns>
        public bool Guillotinar(Documento documento)
        {
            bool retorno = false;

            if(documento.FaseProceso == PasosProceso.paraGuilotinar)
            {
                documento.FaseProceso = PasosProceso.paraEscanear;
                retorno = true;

            }
            return retorno;
        }

        /// <summary>
        /// Da por escaneado el documento que pasa por parámtero  y lo pasa a la fase de revisión previa validación de que está para escanear.
        /// </summary>
        /// <param name="documento">Documento a escanear.</param>
        /// <returns>Verdadero si el documento estaba para escanear. Falso si no.</returns>
        public bool Escanear(Documento documento)
        {
            bool retorno = false;
            if (documento.FaseProceso == PasosProceso.paraEscanear)
            {
                documento.FaseProceso = PasosProceso.paraRevisar;
                retorno = true;

            }
            return retorno;
        }
        /// <summary>
        /// Se revisa el documento que entra por parámtro, y si el segundo parámetro indica que está bien, se da por finalizado el proceso
        ///       Si el segundo parámtro indica que no está bien, se devuelve a la fase de escaneo.       
        /// </summary>
        /// <param name="documento">Documento a guillotinado.</param>
        /// <param name="estaBienElPdf">Documento a guillotinado.</param>
        /// <returns>Verdadero si el documento estaba para guillotinar. Falso si no.</returns>

        public bool Revisar(Documento documento, bool estaBienElPdf)
        {
            bool retorno = false;

            if(documento.FaseProceso == PasosProceso.paraRevisar)
            {
                if (estaBienElPdf)
                {
                    documento.FaseProceso = PasosProceso.finalizado;
                }
                else
                {
                    documento.FaseProceso = PasosProceso.paraEscanear;                   
                }
                retorno = true;
            }
           
            return retorno;
        }
        /// <summary>
        /// Se da por finalizado el proceso previa comprobación de que viene de ser revisado.
        /// </summary>
        /// <param name="documento">Documento que se da por finalizado.</param>
        /// <returns></returns>

        public bool Finalizar(Documento documento)
        {
            bool retorno = false;

            if (documento.FaseProceso == PasosProceso.paraRevisar)
            {
                documento.FaseProceso = PasosProceso.finalizado;
                retorno = true;
            }
            return retorno;
        }
    }
}
