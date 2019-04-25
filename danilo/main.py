import os


from datetime import*
dataAtual = date.today()
#horaAtual = now.hour/now.minute/now.second
#dataTexto = dataAtual.strftime('%d/%m/%y')
matriz = []



def novoCliente(nome, cpf, Tconta, saldo, senha):
  cpf = int(input('Digite o cpf do cliente: '))
  A = open('%s.txt'%cpf, 'w')
  nome = str(input('Digite o nome do cliente: '))
  A.write('%s\n'%nome)
  A.write('%d\n'%cpf)
  Tconta = str(input('Digite o tipo de conta: Salário/Comum/Plus:'))
  A.write('%s\n'%Tconta)
  saldo = float(input('Digite o saldo inicial do cliente: '))
  A.write('%d\n'%saldo)
  senha = int(input('Digite a senha do cliente: '))
  A.write('%d'%senha)
  A.close()

def debita(cpf,senha,valor):
  cpf = int(input('Digite o cpf do cliente: '))
  arq = open('%d.txt'%cpf, 'r')
  for i in arq.readlines():
    lista = []
    lista.append(i.rstrip("\n"))
    senha = input('Digite a senha do cliente: ')
  if lista[4] == senha:
    valor = float(input('digite o valor a ser retirado: '))
    if lista[2] == 'salario':
      taxa = float(valor*0.05)
      saldo1 = valor*1.05
      if saldo1 <= float(i[3]):
        lista[3] = saldo1
        arq.write(lista)
        arq.close()
        lista = []
      elif float(i[3]) - saldo1 < 0:
        print('Não é permitido conta com saldo negativo em conta tipo:salario') 
def main():
  nome = str(input('Digite o nome do cliente: '))
  cpf = int(input('Digite o cpf do cliente: '))
  Tconta = str(input('Digite o tipo de conta: Salário/Comum/Plus: '))
  saldo = float(input('Digite o saldo inicial do cliente: '))
  senha = int(input('Digite a senha do cliente: '))
  valor = float(input('digite o valor a ser retirado: '))
  k = 1
  while k != 0:
    k = int(input('digite o numero: '))
    if k == 1:
      novoCliente(nome, cpf, Tconta, saldo, senha)
    elif k == 2:
      debita(cpf,senha,valor)


main()

