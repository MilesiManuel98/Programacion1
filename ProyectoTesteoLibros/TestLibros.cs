using EjerciciosDePrueba.Repositories;

namespace ProyectoTesteoLibros
{
    public class TestLibros
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public async Task TestObtenerLibros()
        {
            LibrosRepository librosRepository= new LibrosRepository();
            var libros = await librosRepository.ObtenerLibrosAsync();

            Assert.That(libros.Count, Is.Not.EqualTo(0));
        }

        [Test]
        public async Task TestAgregarLibro()
        {
            LibrosRepository librosRepository = new LibrosRepository();
            var libro = await librosRepository.AgregarAsync("LibroTest", "generoTest", 100, "EditorialTest", "sinopsisTest", "protadaTest", "autoTest");
            Assert.That(libro.nombre, Is.EqualTo("LibroTest"));
        }

        [Test]
        public async Task TestEliminarLibro()
        {
            LibrosRepository librosRepository = new LibrosRepository();
            var borrado = await librosRepository.EliminarAsync("665a169269e958000003eccf");
            Assert.That(borrado, Is.EqualTo(true));
        }

        [Test]
        public async Task TestObtenerLibro()
        {
            LibrosRepository librosRepository = new LibrosRepository();
            var libro = await librosRepository.ObtenerPorIdAsync("64aef2eba1ce30200009bd2d");
            Assert.That(libro.nombre, Is.EqualTo("Dulce Hogar"));
        }

        [Test]
        public async Task ActualizarLibro()
        {
            LibrosRepository librosRepository = new LibrosRepository();
            var libro = await librosRepository.AgregarAsync("LibroActualizado", "generoTest", 100, "EditorialTest", "sinopsisTest", "protadaTest", "autoTest");
            Assert.That(libro.nombre, Is.EqualTo("LibroActualizado"));
        }

        [Test]
        public async Task TestObtenerVideojuego()
        {
            VideojuegosRepository videojuegosRepository = new VideojuegosRepository();
            var videojuego = await videojuegosRepository.ObtenerVideojuegoAsync();

            Assert.That(videojuego.Count, Is.Not.EqualTo(0));
        }
    }

}