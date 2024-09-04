<!DOCTYPE html>
<html lang="pt-br">
<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>Formulário Login</title>
    <style>
        @import url('https://fonts.googleapis.com/css2?family=Montserrat:ital,wght@0,100..900;1,100..900&display=swap');
        body{
            font-family: "Montserrat", sans-serif;
        }
        main {
            padding:10px;
            margin: auto;
            width: 400px;
            background-color: #E0E0E0;
            border-radius:10px;
            box-shadow:2px 2px 10px #CACACA;
        }

        h1, form{
            text-align: center;
        }
    </style>
</head>
<body>
    <main>
        <h1>Login no Sitema</h1>
        <hr>
        <form action="./recLogin.php" method="POST">
            <input type="text" name="txtEmail" id="txtEmail" placeholder="Digite o email" required> <br><br>
            <input type="password" name="txtSenha" id="txtSenha" placeholder="Digite a senha"required> <br><br>
            <hr>
            <input type="submit" value="Entrar">
        </form>
    </main>
</body>
</html>