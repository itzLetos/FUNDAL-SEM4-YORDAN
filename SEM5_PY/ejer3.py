n = int(input("Ingrese un numero: "))
suma = 0;

for i in range(1,n+1):
    print("\n",i)

    if (i%2 == 0):
        suma += i

print("\nSuma de pares: ",suma)