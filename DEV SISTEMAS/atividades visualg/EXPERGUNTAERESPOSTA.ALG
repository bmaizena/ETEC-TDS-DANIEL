Algoritmo "exPerguntaeResposta"

Var

   nome: caracter
   resposta: caracter
   iniciar: logico
   resposta2: caracter

Inicio

   escreval("Digite seu Nome: ")
   leia(nome)
   limpatela

   escreval("seja bem vindo ", nome)
   escreval("--------------------")

   escreval("Vamos iniciar, responda com V = verdadeiro / F = falso")
   leia(iniciar)

   se (iniciar = verdadeiro) entao
      limpatela
      escreval("Quem Descorbiu o Brasil?")
      escreval("A - Beyonc�")
      escreval("B - Roberto Carlos")
      escreval("C - Ratinho")
      escreval("D - Pedrinho Alvares Cabral")
      escreval("E - Lula")
      leia(resposta)
      se (resposta = "D")entao
         limpatela
         escreval ("Estou incr�dulo com tanta intelig�ncia")
         timer(1000)

      senao
         limpatela
         escreval("...")
         escreval("Voc� � idiota?... tente novamente")
      fimse

      limpatela
      escreval("Que ano a Sele��o Brasileira foi Penta?")
      escreval("A - 2006")
      escreval("B - 1994")
      escreval("C - 1998")
      escreval("D - 2002")
      leia (resposta2)
      se (resposta2 = "D") entao
         limpatela
         escreval("Voc� Acertou")
      senao
         limpatela
         escreval("Voc� errou")
      fimse
   senao
      limpatela
      escreval("Poxa, Volte depois ent�o")
   fimse

Fimalgoritmo