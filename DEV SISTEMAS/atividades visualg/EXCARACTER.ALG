Algoritmo "exCaracter"

Var
   l_atual, tot_carac, l_encontrado, espaco: inteiro
   frase, l_pesq: caractere


Inicio
   escreval("Digite uma palavra ou frase: ")
   leia(frase)   // armazena palavra ou frase

   tot_carac <- compr(frase)  // recebe o comprimento da variavel 'frase'


   escreval("Qual caracter deseja contar na frase/palavra? ")
   leia(l_pesq)  // armazena o caracter desejado

   para l_atual de 1 ate tot_carac faça // loop de cada caracter da frase

      escreval(copia(frase;l_atual;1), " -> caracter numero ", l_atual)
      //mostra cada letra                               mostra posiçao da letra

      se (copia(frase;l_atual;1) = l_pesq) entao // se a letra for igual o caracter desejado da variavel l_pesq

         l_encontrado <- l_encontrado + 1   //variavel l_encontrado recebe +1

      senao    //se a letra NÃO for igual ao caracter desejado, faz

         se (copia(frase;l_atual;1) = " ") entao  // se a letra for igual o caracter vazio/espaço em branco

            espaco <- espaco +1      //variavel espaço recebe +1
         fimse
      fimse
   fimpara

   escreval("Total de caracteres na palavra/frase: ", tot_carac) //mostra valor total da frase/palavra
   escreval("Total de espaços na palavra/frase: ", espaco)       //mostra quantidade de espaços que a frase/palavra obteve
   escreval("Total de letra: ", l_pesq, " foram: ", l_encontrado)//mostra a letra desejada, e quantas vezes ela aparece




Fimalgoritmo