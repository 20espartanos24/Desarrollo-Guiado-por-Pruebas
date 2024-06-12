import unittest

class TestPromedio(unittest.TestCase):
    def calcular_promedio(self, conjunto):
        if conjunto is None or len(conjunto) == 0:
            raise ValueError("El conjunto no puede ser nulo o vacío.")
        return sum(conjunto) / len(conjunto)

    def test_calcular_promedio_conjunto_valido(self):
        conjunto = [1, 2, 3, 4, 5]
        resultado = self.calcular_promedio(conjunto)
        self.assertEqual(resultado, 3)

    def test_calcular_promedio_conjunto_nulo(self):
        conjunto = None
        with self.assertRaises(ValueError):
            self.calcular_promedio(conjunto)

    def test_calcular_promedio_conjunto_vacio(self):
        conjunto = []
        with self.assertRaises(ValueError):
            self.calcular_promedio(conjunto)

if __name__ == '__main__':
    unittest.main()
