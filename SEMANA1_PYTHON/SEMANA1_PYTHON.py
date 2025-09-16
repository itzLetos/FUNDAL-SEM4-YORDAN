def ejer1():
    nombre = input("Ingrese su nombre: ")
    carrera = input("Ingrese su carrera: ")

    print(f"\n{nombre}, bienvenido al curso de fudamentos de algoritmo de la carrera {carrera}")

def ejer2():
    print("\"Leonardo\"")

def ejer3():
    num1 = int(input("ingrese numero 1: "))
    num2 = int(input("ingrese numero 2: "))
    print ("Suma: ",num1 + num2)
    print ("Resta: ",num1 - num2)
    print ("Multiplicacion: ",num1 * num2)
    print ("Division: ",num1 / num2)

import math #importando libreria math, para raices y exponentes

def ejer4():
    num = float(input("ingrese un numero decimal: "))
    
    raiz = math.sqrt(num)
    redo = round(num,2)
    cubo = math.pow(num,3)
    cubica = num ** 1/3 #otra forma de hacer exponente

    print("Raiz cuadrada: ",raiz)
    print("Redondeado: ",redo)
    print("Al cubo: ",cubo)
    print("Raiz cubica: ",cubica)

def ejer5():
    num = input("ingrese un numero: ")

    ent = int(num)
    dec = float(num)

    print("Resto: ",(ent%2))
    print("Decimal: ",(dec/3))

ejer5()