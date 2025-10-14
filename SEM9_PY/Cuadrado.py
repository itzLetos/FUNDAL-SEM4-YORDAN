class Cuadrado:
    @staticmethod
    def area()->None:
        b = int(input("Ingresa la base: "))
        h = int(input("Ingresa la altura: "))
        print("\nÁrea: ", ((b*h)/2))

    @staticmethod
    def perimetro()->None:
        l1 = int(input("Ingresa lado 1: "))
        l2 = int(input("Ingresa lado 2: "))
        l3 = int(input("Ingresa lado 3: "))
        print("\nPerímetro: ", (l1+l2+l3))