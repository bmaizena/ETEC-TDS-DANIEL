<!DOCTYPE html>
<html lang="en">
<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>Formulário</title>
    <style>
        
    </style>
</head>
<body style= "background-color: gray">
    <h1>Este é um formulário teste</h1>
    <hr>
    <h2>Vamos testar o envio de dados usando o método GET</h2>

    <form action="recDados.php" method="POST">

        <label for="txtNome">Nome</label>
        <input type="text" name="txtNome" id="txtNome" placeholder="seu nome" required>

        <br> <br>

        <label for="numberIdade">Idade </label>
        <input type="number" name="numberIdade" id="numberIdade" placeholder="sua idade" required >

        <br> <br>

        <label for="txtEmail">Email</label>
        <input type="email" name="txtEmail" id="txtEmail" placeholder="seu email" required>

        <br> <br>

        <hr>

        <input type="submit" value="OK">


    </form>
</body>
</html>

