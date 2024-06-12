public class CalculadoraPromedio
{
    public double CalcularPromedio(int[] numeros)
    {
        if (numeros == null || numeros.Length == 0)
        {
            return 0;
        }

        double suma = 0;
        foreach (int numero in numeros)
        {
            suma += numero;
        }

        return suma / numeros.Length;
    }
}


