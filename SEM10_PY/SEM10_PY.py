from Cajero import Cajero
c = Cajero()

conti = "s"

while conti == "s":
    print("\nBIENVENIDOS AL SISTEMA CAJERO\n")
    print("1. Consultar saldo")
    print("2. Depositar dinero")
    print("3. Retirar dinero")
    print("4. Salir\n")

    while True:
       opc = int(input("Ingrese una opción: "))

       if opc in (1,2,3,4): break
       else: print("Opción no válida. Ingrese nuevamente. \n")

    match opc:
        case 1: print("\nSaldo disponible: ",c.consultar())
        case 2: 
            monto = input("\nIngrese el monto a depositar: ")
            c.despositar(monto)
        case 3: 
            monto = input("\nIngrese el monto a retirar: ")
            c.retirar(monto)
        case 4: quit()

    while True:
        conti = input("\n¿Desea continuar? (s/n): ").lower().strip()#strip quita espacios antes o despues de lo que pomgas y asi no genera errores de texto

        if conti in ("s", "n"): break
        else: print("Opción no válida. Presione solo 's' o 'n' ")