lado1 = int(input("ingrese lado 1: "))
lado2 = int(input("ingrese lado 2: "))
lado3 = int(input("ingrese lado 3: "))

if lado1 == lado2 == lado3:
    print("\nTriangulo equilatero")
elif lado1 == lado2 or lado2 == lado3 or lado1 == lado3:
    print("\nTriangulo isosceles")
else:
    print("\nTriangulo escaleno")