using TrucoConsola.Cartas;
using TrucoConsola.Truco;
using Xunit;

namespace TrucoConsola.Tests;

public class PaqueteMazoTests
{
    [Fact]
    public void CreacionCartas_DeberiaCrear40Cartas()
    {
        PaqueteMazo mazo = new PaqueteMazo();

        mazo.CreacionCartas();
        List<Carta> cartas = mazo.MostrarCartas();

        Assert.Equal(40, cartas.Count);
    }
    [Fact]
    public void CreacionCartas_DeberiaNoAcceptarNull()
    {

        PaqueteMazo mazo = new PaqueteMazo();
        List<Carta> cartas = mazo.MostrarCartas();

        Assert.NotNull(cartas);

    }
    [Fact]
    public void CreacionCartas_NoDebeIncluir8Ni9()
    {
        PaqueteMazo mazo = new PaqueteMazo();

        mazo.CreacionCartas();
        var numeros = mazo.MostrarCartas().Select(c => c.Numero);

        Assert.DoesNotContain(8, numeros);
        Assert.DoesNotContain(9, numeros);
    }


    [Fact]
    public void CreacionCartas_DeberiaContenerLosCuatroPalos()
    {
        // Arrange
        var mazo = new PaqueteMazo();

        // Act
        mazo.CreacionCartas();
        var cartas = mazo.MostrarCartas();
        var palos = cartas.Select(c => c.Palo).Distinct().ToList();

        // Assert
        Assert.Contains("Oro", palos);
        Assert.Contains("Basto", palos);
        Assert.Contains("Copa", palos);
        Assert.Contains("Espada", palos);
    }

}
