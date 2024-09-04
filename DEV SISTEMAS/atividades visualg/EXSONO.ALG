Algoritmo "exsono"

Var
   idade: inteiro


Inicio
   escreva ("qual sua idade: ")
   leia (idade)

   se (idade <=0) entao
      escreval ("feto")
   senao
      se (idade <= 2) entao
         escreval ("Seu horário de sono deve ser de 11 a 14 horas por dia")
      senao
         se (idade <= 5)entao
            escreval ("Seu horário de sono deve ser de 10 a 13 horas por dia")
         senao
            se (idade <= 12)entao
               escreval ("Seu horário de sono deve ser de 9 a 12 horas por dia")
            senao
               se (idade <=18) entao
                  escreval ("Seu horário de sono deve ser de 8 a 10 horas por dia")
               senao
                  se (idade <=60) entao
                     escreval ("Seu horário de sono deve ser de 7 horas ou mais por dia")
                  senao
                     se (idade <= 64) entao
                        escreval ("Seu horário de sono deve ser de 7 a 9 horas por dia")
                     senao
                        escreval ("Seu horário de sono deve ser de 7 a 8 horas por dia")

                     fimse
                  fimse
               fimse
            fimse
         fimse
      fimse
   fimse
Fimalgoritmo


