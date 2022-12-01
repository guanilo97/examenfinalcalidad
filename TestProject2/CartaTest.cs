using Calidad20222.web.Helper;
using Calidad20222.web.Models;
using Calidad20222.web.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace TestProject2
{
    public class CartaTest
    {
        [Test]
        public void Caso01()
        {
            var rn = new PokerService();
            var carta = GeneradorMano.Generar();
            var jugada= rn.GetJugada(carta);

            Assert.AreEqual("TRIO", jugada);
        }
        [Test]
        public void Caso02()
        {
            var rn = new PokerService();
            var carta = GeneradorMano.Generar();
            var jugada = rn.GetJugada(carta);

            Assert.AreEqual("TRIO", jugada);
        }
        [Test]
        public void Caso03()
        {
            var rn = new PokerService();
            var carta = GeneradorMano.Generar();
            var jugada = rn.GetJugada(carta);

            Assert.AreEqual("TRIO", jugada);
        }
        [Test]
        public void Caso04()
        {
            var rn = new PokerService();
            var carta = GeneradorMano.Generar();
            var jugada = rn.GetJugada(carta);

            Assert.AreEqual("TRIO", jugada);
        }
        [Test]
        public void Caso05()
        {
            var rn = new PokerService();
            var carta = GeneradorMano.Generar();
            var jugada = rn.GetJugada(carta);

            Assert.AreEqual("TRIO", jugada);
        }
        [Test]
        public void Caso06()
        {
            var rn = new PokerService();
            var carta = GeneradorMano.Generar();
            var jugada = rn.GetJugada(carta);

            Assert.AreEqual("TRIO", jugada);
        }
        [Test]
        public void Caso07()
        {
            var rn = new PokerService();
            var carta = GeneradorMano.Generar();
            var jugada = rn.GetJugada(carta);

            Assert.AreEqual("TRIO", jugada);
        }
        [Test]
        public void Caso08()
        {
            var rn = new PokerService();
            var carta = GeneradorMano.Generar();
            var jugada = rn.GetJugada(carta);

            Assert.AreEqual("TRIO", jugada);
        }
        [Test]
        public void Caso09()
        {
            var rn = new PokerService();
            var carta = GeneradorMano.Generar();
            var jugada = rn.GetJugada(carta);

            Assert.AreEqual("TRIO", jugada);
        }
        [Test]
        public void Caso10()
        {
            var rn = new PokerService();
            var carta = GeneradorMano.Generar();
            var jugada = rn.GetJugada(carta);

            Assert.AreEqual("TRIO", jugada);
        }
    }
}
