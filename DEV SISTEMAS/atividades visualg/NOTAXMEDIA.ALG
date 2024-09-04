Algoritmo "notaXmedia"

Var
   n, x, quant: inteiro
   media: real


Inicio
   escreval("quantas notas você quer digitar?")
   leia(quant)
   para x de 1 ate quant faça
      escreval("digite a nota", x)
      leia(n)
      media <- media+n
   fimpara

   escreval("a media do aluno é ",media/quant)

Fimalgoritmo