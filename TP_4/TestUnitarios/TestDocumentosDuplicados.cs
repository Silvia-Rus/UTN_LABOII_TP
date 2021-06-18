using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using Entidades;

namespace TestUnitarios
{
    [TestClass]
    public class TestDocumentosDuplicados
    {
        Documento articuloUno = new Articulo("Keldysh Rotation in the Large-N Expansion ", "Horava,Petr, et. al", 2010, 3, "arXiv:2010.10671", 1, "", Encuadernacion.No);
        Documento articuloDos = new Articulo("Keldysh Rotation in the Large-N Expansion ", "Horava,Petr, et. al", 2010, 3, "arXiv:2010.10671", 1, "", Encuadernacion.No);
        Documento articuloTres = new Articulo("A Semiclassical, Entropic Proof of a Weak Gravity Conjecture", "Fihser, Zachary, et. al", 2017, 4, "arXiv:1706.08257", 3, "",Encuadernacion.Si_Guillotinar);
        Documento libroUno = new Libro("Cien años de Soledad", "García Márquez, Gabriel", 2017, 154, "9788439732471", 1, "", Encuadernacion.Si_NoGuillotinar);
        Documento libroDos = new Libro("Cien años de Soledad", "García Márquez, Gabriel", 2017, 154, "9788439732471", 2, "", Encuadernacion.Si_NoGuillotinar);
        Documento libroTres = new Libro("Crónica de una muerte anunciada", "García Márquez, Gabriel", 2018, 136, "9788466346825", 2, "", Encuadernacion.Si_NoGuillotinar);

        Procesador procesador = new Procesador("Procesador de prueba");

        /// <summary>
        /// Valida la igualdad entre dos documentos con el mismo barcode. 
        /// </summary>
        [TestMethod]
        public void TestOperadorIgualadorDocumentos_True()
        {
            //Barcode iguales. Los dos artículos.
            Assert.IsTrue(articuloUno == articuloDos);

            //Barcode iguales. Los dos libros.
            Assert.IsTrue(libroDos == libroTres);

            //Barcode iguales. Un libro y un artículo
            Assert.IsTrue(libroUno == articuloUno);
        }
        /// <summary>
        /// Valida la desigualdad entre dos documentos con distinto barcode.
        /// </summary>
        [TestMethod]
        public void TestOperadorIgualadorDocumentos_False()
        {
            //Barcode distintos. Los dos artículos.
            Assert.IsFalse(articuloDos == articuloTres);

            //Barcode distintos. Los dos libros.
            Assert.IsFalse(libroDos == libroUno);

            //Barcode distintos. Un libro y un artículo
            Assert.IsFalse(libroTres == articuloDos);
        }
        /// <summary>
        /// Valida que no se puede añadir un documento a una lista en la que ya hay uno que tiene el mismo barcode, el mismo id o los dos. //IMPLEMENTACIÓN TEMA 16 - TEST UNITARIOS
        /// </summary>
        [TestMethod]
        public void TestAniadirDocALista_False()
        {
            procesador.Documentos.Add(articuloUno);
            procesador.Documentos.Add(libroDos);

            //Igual ID. Igual Barcode.
            Assert.IsFalse(procesador + articuloDos);

            //Diferente ID. Igual Barcode
            Assert.IsFalse(procesador + libroTres);

            //Igual ID. Diferente Barcode
            Assert.IsFalse(procesador + libroUno);

        }
        /// <summary>
        /// Valida que  se puede añadir un documento a una lista en la que ya hay uno que tiene el mismo barcode, el mismo id o los dos.
        /// </summary>
        [TestMethod]
        public void TestAniadirDocALista_True()
        {
            procesador.Documentos.Add(articuloTres);

            Assert.IsTrue(procesador + articuloUno);
            Assert.IsTrue(procesador + libroDos);
        }

    }
}
