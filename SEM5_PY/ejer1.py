edad = int(input("ingrese la edad: "))
if edad >= 18:
    print("elegible para votar")

    if edad >= 25:
        print("elegible para ser candidato")
    else:
        print("no es elegible para ser candidato")
else:
    print("no es elgible para votar")