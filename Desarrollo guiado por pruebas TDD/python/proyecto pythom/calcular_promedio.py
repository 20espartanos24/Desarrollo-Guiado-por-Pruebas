def calcular_promedio(conjunto):
    if conjunto is None or len(conjunto) == 0:
        raise ValueError("El conjunto no puede ser nulo o vacío.")
    return sum(conjunto) / len(conjunto)
