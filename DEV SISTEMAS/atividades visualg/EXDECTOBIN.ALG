Algoritmo "exDecToBin"

Var
   num, decimal: inteiro
   bin: caracter


Inicio
   escreval ("Digite um n�mero decimal para converter em bin�rio: ")
   leia(num)

   decimal <- num

   enquanto num > 0 faca
      se (num % 2) = 0 entao
         bin <- "0" + bin
         escreva("bin verdadeiro", bin)
      senao
         bin <- "1" + bin
         escreva("bin verdadeiro", bin)
      fimse
      num <- num\2
   fimenquanto

   escreval("o numero decimal", decimal," � ", bin)


Fimalgoritmo