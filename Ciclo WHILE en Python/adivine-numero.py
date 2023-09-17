import random

# Paso 1: Generar un número aleatorio entre 1 y 100
numero_secreto = random.randint(1, 100)

# Paso 2: Inicializar variables
intentos = 0
adivinado = False

# Paso 3: Ciclo while para adivinar el número
while not adivinado:
    # Incrementar el contador de intentos
    intentos += 1

    # Paso 4: Pedir al usuario que ingrese un número
    intento = int(input("Intento #{}, Ingresa un número entre 1 y 100: ".format(intentos)))

    # Paso 5: Comparar el número ingresado con el número secreto
    if intento == numero_secreto:
        adivinado = True
    elif intento < numero_secreto:
        print("El número secreto es mayor. Intenta de nuevo.")
    else:
        print("El número secreto es menor. Intenta de nuevo.")

# Paso 6: Mostrar el resultado
print("¡Felicidades! Adivinaste el número secreto ({}) en {} intentos.".format(numero_secreto, intentos))
