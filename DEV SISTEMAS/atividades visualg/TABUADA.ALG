Algoritmo "tabuada"

Var
   ini, cont, fim, tabuada: inteiro



Inicio

   escreval("qual inicio da tabuada você quer?")
   leia (ini)

   escreval("qual o fim da tabuada?")
   leia(fim)

   se (ini < fim) entao
      para tabuada de ini ate fim passo 1 faça
         escreval("--------------")
         para cont de 1 ate 10 passo 1 faça
            escreval(tabuada, " x", cont," =", tabuada * cont)

         fimpara
      fimpara
      
   senao
      para tabuada de ini ate fim passo -1 faça
         escreval("--------------")
         para cont de 1 ate 10 passo 1 faça
            escreval(tabuada, " x", cont," =", tabuada * cont)

         fimpara
      fimpara
   fimse

Fimalgoritmo