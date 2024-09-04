
<?php
session_start();
if(isset($_SESSION['email'])) {
    
    ?>
    <!DOCTYPE html>
    <html lang="pt-br">
    <head>
        <meta charset="UTF-8">
        <meta name="viewport" content="width=device-width, initial-scale=1.0">
        <title>Página Restrita</title>
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

        h1,h3, form{
            text-align: center;
            
        }
        a{
            background-color:#99FFFF;
            padding:5px;
            border-radius:10px;
            box-shadow:2px 2px 10px #CACACA;
        }
        </style>
    </head>
    <body>
        <main>
            <h1>Página de Acesso Restrito</h1>
            <hr>
            <h3>Para você acessar esta página só existe 2 possibilidades:</h3>
            <ol>
                <li>Você fez o Login corretamente com Usuário e Senha</li>
                <li>Seu sistema está com uma falha de segurança</li>
            </ol>
            <hr>
            <a href="./login/logout.php">Logout do Sistema</a>
        </main>
    </body>
    </html>
<?php 

}
else{
    header('location: ./login/index.php');
}



