cant = int(input("Ingrese la cantidad de numeros: "))
pares = impares = ceros = 0

for i in range(1, cant+1):
    num = int(input(f"\nIngrese numero {i}: "))

    if num == 0:
        ceros+=1 # ceros++
    elif num%2 == 0:
        pares+=1
    else:
        impares+=1

print("\n# Pares: ", pares)
print("\n# Impares: ", impares)
print("\n# Ceros: ", ceros)
