print("Calcular o melhor consumo de combustível")

alcool = input("Informe o valor do Álcool: R$ ")
alcool = float(alcool.replace(",", "."))
gasolina = input("Informe o valor da Gasolina: R$ ")
gasolina = float(gasolina.replace(",", "."))

abastecimentoIdeal = alcool / gasolina
resultado = "{:.2f}".format(abastecimentoIdeal)

if float(resultado) > 0.65:
    print(f"É aconselhável abastecer com Álcool: ", "{:.2f}".format(abastecimentoIdeal))
    if float(resultado) == 0.72:
        print("Neste caso também economizará ao abastecer com álcool")
else:
    print("É aconselhável abastecer com Gasolina: ", "{:.2f}".format(abastecimentoIdeal))