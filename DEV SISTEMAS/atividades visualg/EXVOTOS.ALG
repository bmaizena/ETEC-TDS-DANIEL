Algoritmo "exVotos"

Var
   idade: inteiro


Inicio
   escreva ("qual sua idade: ")
   leia (idade)

   se (idade < 16) entao
      escreval ("VOTO NÃO PERMITIDO")

   senao

      se (idade <= 17)entao
         escreval ("VOTO OPCIONAL")
      senao

         se (idade <= 70)entao
            escreval ("VOTO OBRIGATÓRIO")
         senao
            escreval ("VOTO OPCIONAL")

         fimse
      fimse
   fimse
Fimalgoritmo


