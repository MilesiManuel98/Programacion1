using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoTesteoLibros
{
    internal class TestTriangulo
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void TestEquilatero()
        {
            string resultado = ProgramEjercicios.testTipoDeTriangulo(1, 1, 1);
            Assert.That(resultado, Is.EqualTo("equilatero"));
        }
        public void TestIsosceles()
        {
            string resultado = ProgramEjercicios.testTipoDeTriangulo(10, 10, 1);
            Assert.That(resultado, Is.EqualTo("isósceles"));
        }
        public void TestEscaleno()
        {
            string resultado = ProgramEjercicios.testTipoDeTriangulo(10, 11, 12);
            Assert.That(resultado, Is.EqualTo("escaleno"));
        }
    }
}
