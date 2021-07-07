using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Entidades;
using Serializador;
using System.Collections.Generic;

namespace TestUnitarios
{
    [TestClass]
    public class TestSerializador
    {
        Procesador procesador = new Procesador("Procesador para Test Unitarios");
        Libro articuloPrueba = (Libro)Documento.GenerarDocumento("Libro", "Yerma", "García Lorca, Federico", "2015", "35", "9788467045017", "1", "", 1);
        Xml<List<Documento>> miVariable = new Xml<List<Documento>>();
        List<Documento> listaDeserializadora = new List<Documento>();
        /// <summary>
        /// Testea el serializador.
        /// </summary>
        [TestMethod]
        public void TestExportar()
        {

            Assert.IsTrue(miVariable.Exportar(procesador.Documentos));
        }
        /// <summary>
        /// Testea la exportación de documentos. No deben poder exportarse listas vacías.
        /// </summary>
        [TestMethod]
        public void TestExportarDocumentos_False()
        {
            Assert.IsFalse(Documento.ExportarDocumentos(procesador.Documentos));
        }
        /// <summary>
        /// Testea la exportación de documentos. Debe exportar cuando la lista tiene contenido.
        /// </summary>
        [TestMethod]
        public void TestExportarDocumentos_True()
        {
            procesador.Documentos.Add(articuloPrueba);
            Assert.IsTrue(Documento.ExportarDocumentos(procesador.Documentos));
        }
        /// <summary>
        /// Testea el método de importación.
        /// </summary>
        [TestMethod]
        public void TestImportar()
        {
            Assert.IsTrue(miVariable.Importar(Environment.CurrentDirectory + @"\ImportXml\Inicio.xml", out listaDeserializadora));
            
            
            Assert.ThrowsException<Exception>(()=>miVariable.Importar(Environment.CurrentDirectory + @"\ImportXml\XMLQueNoExiste.xml", out listaDeserializadora));
      
        }

    }
}
