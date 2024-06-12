using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

public class Promedio
{
    public double CalcularPromedio(int[] conjunto)
    {
        if (conjunto == null || conjunto.Length == 0)
        {
            throw new ArgumentException("El conjunto no puede ser nulo o vacío.");
        }

        double suma = 0;
        for (int i = 0; i < conjunto.Length; i++)
        {
            suma += conjunto[i];
        }

        return suma / conjunto.Length;
    }
}

[TestClass]
public class PromedioTests
{
    private Promedio _promedio;

    [TestInitialize]
    public void TestInitialize()
    {
        _promedio = new Promedio();
    }

    [TestMethod]
    public void TestCalcularPromedio_ConjuntoValido_DeberiaRetornarPromedioCorrecto()
    {
        // Preparar
        int[] conjunto = { 1, 2, 3, 4, 5 };

        // Actuar
        double resultado = _promedio.CalcularPromedio(conjunto);

        // Afirmar
        Assert.AreEqual(3, resultado);
    }

    [TestMethod]
    [ExpectedException(typeof(ArgumentException))]
    public void TestCalcularPromedio_ConjuntoNulo_DeberiaLanzarExcepcion()
    {
        // Preparar
        int[] conjunto = null;

        // Actuar
        _promedio.CalcularPromedio(conjunto);
    }

    [TestMethod]
    [ExpectedException(typeof(ArgumentException))]
    public void TestCalcularPromedio_ConjuntoVacio_DeberiaLanzarExcepcion()
    {
        // Preparar
        int[] conjunto = new int[0];

        // Actuar
        _promedio.CalcularPromedio(conjunto);
    }
}
