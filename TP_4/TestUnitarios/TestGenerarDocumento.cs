using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Entidades;

namespace TestUnitarios
{
    [TestClass]
    public class TestGenerarDocumento
    {
        /// <summary>
        /// Prueba el método que genera documentos tras una validación.
        /// </summary>
        /// <param name="tipo">Tipo de documento a crear.</param>
        /// <param name="titulo"></param>
        /// <param name="autor"></param>
        /// <param name="anio"></param>
        /// <param name="numeroPaginas"></param>
        /// <param name="id"></param>
        /// <param name="barcode"></param>
        /// <param name="notas"></param>
        /// <param name="encIndex"></param>
        [TestMethod]
        [DataRow("Libro", "Yerma", "García Lorca, Federico", "2015", "35", "9788467045017", "1", "", 1)]
        [DataRow("Libro", "Bodas de Sangre", "García Lorca, Federico", "2018", "113", "9788416107858", "2", "", 1)]
        public void TestGeneracionLibro_IsNotNull(string tipo,
                                                string titulo,
                                                string autor,
                                                string anio,
                                                string numeroPaginas,
                                                string id,
                                                string barcode,
                                                string notas,
                                                int encIndex)
        {
            Documento resultado = (Libro)Documento.GenerarDocumento(tipo, titulo, autor, anio, numeroPaginas, id, barcode, notas, encIndex);

            Assert.IsNotNull(resultado);
        }
        /// <summary>
        /// Prueba el método que NO genera documentos tras no pasar la validación.
        /// </summary>
        /// <param name="tipo">Tipo de documento a crear.</param>
        /// <param name="titulo"></param>
        /// <param name="autor"></param>
        /// <param name="anio"></param>
        /// <param name="numeroPaginas"></param>
        /// <param name="id"></param>
        /// <param name="barcode"></param>
        /// <param name="notas"></param>
        /// <param name="encIndex"></param>
        [TestMethod]
        [DataRow("Libro", "Yerma", "García Lorca, Federico", "xxxb", "35", "9788467045017", "1", "", 1)] //Año no son cifras
        [DataRow("Libro", "Yerma", "García Lorca, Federico", "2022", "35", "9788467045017", "1", "", 1)] //Año está en el futuro
        [DataRow("Libro", "Yerma", "García Lorca, Federico", "-3", "35", "9788467045017", "1", "", 1)] //Año está en negativo
        [DataRow("Libro", "", "García Lorca, Federico", "2015", "35", "9788467045017", "1", "", 1)] //No lleva título
        [DataRow("Libro", "Yerma", "García Lorca, Federico", "2015", "u", "9788467045017", "1", "", 1)] //Páginas no son cifras
        [DataRow("Libro", "Yerma", "García Lorca, Federico", "2015", "0", "9788467045017", "1", "", 1)] //Páginas es menor a 1
        [DataRow("Libro", "Yerma", "García Lorca, Federico", "2015", "35", "9788467045017", "o", "", 1)] //Barcode no son cifras
        [DataRow("Libro", "Yerma", "García Lorca, Federico", "2015", "35", "9788467045017", "-3", "", 1)] //Barcode es menor a 0
        public void TestGeneracionLibro_isNull(string tipo,
                                                string titulo,
                                                string autor,
                                                string anio,
                                                string numeroPaginas,
                                                string id,
                                                string barcode,
                                                string notas,
                                                int encIndex)
        {

            Documento resultado = (Libro)Documento.GenerarDocumento(tipo, titulo, autor, anio, numeroPaginas, id, barcode, notas, encIndex);

            Assert.IsNull(resultado);
        }
    }
}
