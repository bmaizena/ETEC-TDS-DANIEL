Algoritmo "exTotalValor"

Var

   total_recebido, valor_recebido: real

Inicio

   enquanto (total_recebido <= 100) faca
      escreval ("O total atual é de: ", total_recebido)
      escreval("--------------")

      escreval ("qual valor você deseja adicionar? ")
      leia(valor_recebido)

      total_recebido <- valor_recebido + total_recebido

      limpatela
   fimenquanto
   
   escreval("o Valor atual ficou", total_recebido)




Fimalgoritmo