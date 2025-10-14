class Triangulo:
    
    def area(self)->None:
        b = int(input("\nIngresa la base: "))
        h = int(input("\nIngresa la altura: "))
        print("\nÁrea: ", ((b*h)/2))

    def perimetro(self)->None:
        l1 = int(input("\nIngresa lado 1: "))
        l2 = int(input("\nIngresa lado 2: "))
        l3 = int(input("\nIngresa lado 3: "))
        print("\nPerímetro: ", (l1+l2+l3))