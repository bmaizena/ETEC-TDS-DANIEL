<!DOCTYPE html>
<html lang="pt-br">
<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>Página Principal</title>
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

        h1{
            text-align: center;
        }
    </style>
</head>
<body>
    <main>
        <h1>Página de Abertura</h1>
        
        <ul>
            <li><a href="/cadUser/frmCadUser.php">Cadastrar Novo Usuario</a></li>
        
            <?php
                session_start();
                if(isset($_SESSION['email'])){ ?>
                    <li><a href="/paginaRestrita.php">Página de Acesso Restrito</a></li>
                <?php } else { ?>
                    <li><a href="/login/index.php">Fazer Login</a></li>
               <?php } ?>
        </ul>
    </main>
</body>
</html>