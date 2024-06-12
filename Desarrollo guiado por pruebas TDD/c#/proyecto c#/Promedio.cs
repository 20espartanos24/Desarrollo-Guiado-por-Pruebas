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
