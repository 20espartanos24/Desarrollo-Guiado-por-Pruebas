import unittest

class TestPromedio(unittest.TestCase):
    def test_calcular_promedio_conjunto_valido(self):
        conjunto = [1, 2, 3, 4, 5]
        resultado = calcular_promedio(conjunto)
        self.assertEqual(resultado, 3)

    def test_calcular_promedio_conjunto_nulo(self):
        conjunto = None
        with self.assertRaises(ValueError):
            calcular_promedio(conjunto)

    def test_calcular_promedio_conjunto_vacio(self):
        conjunto = []
        with self.assertRaises(ValueError):
            calcular_promedio(conjunto)

if __name__ == '__main__':
    unittest.main()
