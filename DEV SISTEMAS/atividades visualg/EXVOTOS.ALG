Algoritmo "exVotos"

Var
   idade: inteiro


Inicio
   escreva ("qual sua idade: ")
   leia (idade)

   se (idade < 16) entao
      escreval ("VOTO N�O PERMITIDO")

   senao

      se (idade <= 17)entao
         escreval ("VOTO OPCIONAL")
      senao

         se (idade <= 70)entao
            escreval ("VOTO OBRIGAT�RIO")
         senao
            escreval ("VOTO OPCIONAL")

         fimse
      fimse
   fimse
Fimalgoritmo


