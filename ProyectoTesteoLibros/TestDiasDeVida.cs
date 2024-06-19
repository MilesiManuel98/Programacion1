using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoTesteoLibros
{
    internal class TestDiasDeVida
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Test1año1mes1dia()
        {
            int diasTotales = ProgramEjercicios.testCalcularDiasDeVida(1, 1, 1);
            Assert.That(diasTotales,Is.EqualTo(396));
        }
    }
}
