using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Entidades
{
    public class Procesador
    {
        private List<Documento> documentos;
        private string nombre;

        /// <summary>
        /// Constructor que inicia la lista.
        /// </summary>
        private Procesador()
        {
            this.documentos = new List<Documento>();
        }

        public List<Documento> Documentos
        {
            get { return  this.documentos; }
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

            if(documento.FaseProceso == PasosProceso.Distribuir)
            {              
                if(documento.EstadoEncuadernacion == Encuadernacion.Si_Guillotinar)
                {
                    documento.FaseProceso = PasosProceso.Guillotinar;
                }
                else if(documento.EstadoEncuadernacion == Encuadernacion.No || documento.EstadoEncuadernacion == Encuadernacion.Si_NoGuillotinar)
                {
                    documento.FaseProceso = PasosProceso.Escanear;
                }
                documento.FechaDistribucion = DateTime.Now;
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

            if(documento.FaseProceso == PasosProceso.Guillotinar)
            {
                documento.FaseProceso = PasosProceso.Escanear;
                documento.FechaGuillotinado = DateTime.Now;

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
            if (documento.FaseProceso == PasosProceso.Escanear)
            {
                documento.FaseProceso = PasosProceso.Revisar;
                documento.FechaEscaneo = DateTime.Now;

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

            if(documento.FaseProceso == PasosProceso.Revisar)
            {
                if (estaBienElPdf)
                {
                    documento.FaseProceso = PasosProceso.Aprobado;
                }
                else
                {
                    documento.FaseProceso = PasosProceso.Escanear;                   
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

            if (documento.FaseProceso == PasosProceso.Revisar)
            {
                documento.FaseProceso = PasosProceso.Aprobado;
                retorno = true;
            }
            return retorno;
        }

        /// <summary>
        /// Suma un documento a una lista de documento en el caso de que no esté ya en ella.
        /// </summary>
        /// <param name="documentos">Lista a la que añadir el documento.</param>
        /// <param name="d">Documento a añadir.</param>
        /// <returns>Lista de documentos que entró por parámetro.</returns>
        public static bool operator +(Procesador p, Documento d)
        {
            bool retorno = false;
            if (p.documentos != d)
            {
                p.documentos.Add(d);
                retorno = true; ;
            }
            return retorno;
        }

        public List<Documento> ListaFiltrada(List<Documento> listaCompleta, PasosProceso paso)
        {
            List<Documento> listaFiltrada = new List<Documento>();

            foreach (Documento item in listaCompleta)
            {
                if (item.FaseProceso == paso)
                {
                    listaFiltrada.Add(item);
                }
            }

            return listaFiltrada;
        }

    }
}
