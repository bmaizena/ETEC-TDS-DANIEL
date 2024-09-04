<!DOCTYPE html>
<html lang="pt-br">
<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>Formulário</title>
    <style>
        body {
            background-color :	#DCDCDC;
            text-align: center;
            font-size: 20px
        }

        form {
            border: 1px solid black;
            width: 600px;
            margin: auto;
            padding: 10px;
            border-radius: 10px;
            box-shadow: 3px 3px 3px 2px gray;
        }

        input {
            margin: 10px;
            height: 30px;
            
            border-radius: 8px;
            
        }

        #enviar {
            width: 100px;
            font-size: 20px;
            font-weight: bold
        }
    </style>
</head>
<body>

    <h1>Formulário</h1>
    

    <form action="receberDados.php" method="POST">

    <label for="txtNome">Digite seu Nome:</label>
    <input type="text" name="txtNome" id="txtNome" required minlength="3">
    <br>

    <label for="txtIdade">Digite sua Idade:</label>
    <input type="number" name="txtIdade" id="txtIdade" required>
    <br>

    <label for="txtSenha">Digite sua Senha:</label>
    <input type="password" name="txtSenha" id="txtSenha" required>
    <br>

    
    <input id="enviar" type="submit" value="Enviar">


    </form>
    
</body>
</html>