nome = input()
salario = float(input())
totalVendas = float(input())

totalReceber = salario + totalVendas * 0.15

print(f"TOTAL = R$ {totalReceber:.2f}")