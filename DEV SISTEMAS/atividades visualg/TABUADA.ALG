Algoritmo "tabuada"

Var
   ini, cont, fim, tabuada: inteiro



Inicio

   escreval("qual inicio da tabuada voc� quer?")
   leia (ini)

   escreval("qual o fim da tabuada?")
   leia(fim)

   se (ini < fim) entao
      para tabuada de ini ate fim passo 1 fa�a
         escreval("--------------")
         para cont de 1 ate 10 passo 1 fa�a
            escreval(tabuada, " x", cont," =", tabuada * cont)

         fimpara
      fimpara
      
   senao
      para tabuada de ini ate fim passo -1 fa�a
         escreval("--------------")
         para cont de 1 ate 10 passo 1 fa�a
            escreval(tabuada, " x", cont," =", tabuada * cont)

         fimpara
      fimpara
   fimse

Fimalgoritmo