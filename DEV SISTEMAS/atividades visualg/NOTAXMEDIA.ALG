Algoritmo "notaXmedia"

Var
   n, x, quant: inteiro
   media: real


Inicio
   escreval("quantas notas voc� quer digitar?")
   leia(quant)
   para x de 1 ate quant fa�a
      escreval("digite a nota", x)
      leia(n)
      media <- media+n
   fimpara

   escreval("a media do aluno � ",media/quant)

Fimalgoritmo