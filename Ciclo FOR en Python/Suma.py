# Programa para calcular la suma de números en un rango

# Paso 1: Solicitar al usuario que ingrese el rango de números
inicio = int(input("Ingrese el número de inicio: "))
fin = int(input("Ingrese el número de fin: "))

# Paso 2: Inicializar una variable para almacenar la suma
suma = 0

# Paso 3: Usar un ciclo for para sumar los números en el rango
for numero in range(inicio, fin + 1):
    suma += numero

# Paso 4: Mostrar el resultado
print(f"La suma de los números del {inicio} al {fin} es: {suma}")