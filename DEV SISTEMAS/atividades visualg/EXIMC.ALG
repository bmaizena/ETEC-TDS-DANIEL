Algoritmo "exIMC"

Var
   peso: real
   altura: real
   imc:real
   opcao: inteiro


Inicio
   escreva ("informe seu peso em KG: ")
   leia(peso)
   
   escreva("informe sua altura (em CM ou Metros): ")
   leia (altura)
   
   escreval("Qual foi sua Opção: (CM ou M)")
   escreval ("1 = Centimetros")
   escreval ("2 = Metros")
   leia(opcao)

   se (opcao = 1)entao
      altura <- (altura / 100)
   fimse

   imc <- peso / (altura^2)

   escreval("Seu IMC é ", imc)

   se (imc < 18.5) entao
      escreval ("Baixo Peso")
   senao
      se (imc <24.99) entao
         escreval ("Peso Normal")
      senao
         se (imc <29.99) entao
            escreval ("Sobrepeso")
         senao

            escreval ("Obesidade")
         fimse
      fimse
   fimse



Fimalgoritmo