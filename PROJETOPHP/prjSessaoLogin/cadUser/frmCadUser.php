<?php
require_once('../conexao.php');
?>


<!DOCTYPE html>
<html lang="pt-br">
<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>Exercicio Login</title>
    
    <style>
        @import url('https://fonts.googleapis.com/css2?family=Montserrat:ital,wght@0,100..900;1,100..900&display=swap');
        body{
            text-align: center;
            background-color:'red';
            font-family: "Montserrat", sans-serif;
        }
        table {
            border-collapse: collapse;
            margin: auto;
            box-shadow: 3px 3px 3px 10px rgb(0,0,0,5%);
            font-size:14px
        }
        td{
            border: 1px solid black;
            padding: 10px;
        }

        tr:nth-child(even) {
            background-color: rgb(192,192,192, 0.433);
        }

        .titulo{
            font-weight: bold;
            font-size:18px;
           
        }

        main{
            width: 50%;
            margin: auto;
            padding: 20px;
            background-color: #E0E0E0;
            border-radius:10px;
            box-shadow:2px 2px 10px #CACACA;
            margin-bottom:10px;
        }

        input{
            border-radius:4px;
            font-family: "Montserrat", sans-serif;
            padding: 8px;
        }
        #botaoCad {
            background-color: #1E90FF;
            font-weight:bold;
            padding: 10px;
            cursor: pointer;
        }

        #botaoCad:hover {
            
            background-color: #1b3ba6;
            font-weight:bold;
            color: #fff;
            transition: 0.3s;
            transform: translateY(-2px);
        }

        #botaoLista{
            cursor: pointer;
            font-weight:bold;
            box-shadow:2px 2px 10px #CACACA;
        }
        #botaoLista:hover{
            transition: 0.1s;
            transform: translateY(-1px);
            background-color:#FFFFCC;
        }
        .lista{
            display:none;
        }
        #botaoLista:active ~.lista {
            display: block;
        }
    </style>
</head>
<body>
    <main>
        <h1>Cadastro de Usuário</h1>
        
        <form action="recCadUser.php" method="POST">
            <input type="text" name="txtEmail" id="txtEmail" required placeholder="Informe seu email">
            <br><br>
            <input type="text" name="txtNome" id="txtNome" required placeholder="Informe seu nome">
            <br><br>
            <input type="password" name="txtSenha" id="txtSenha" required placeholder="Informe uma senha">
        
            <br><br>
        
            <input type="submit" value="Cadastrar" id="botaoCad">
        </form>
    </main>

    
    <input id="botaoLista"type="button" value="Segure para mostrar lista de usuários">
    <div class="lista">
        
        <h2>Lista de Usuarios</h2>
        <table border="1">
        
            <tr>
                <td class="titulo" style="background-color: #4169E1;">ID</td>
                <td class="titulo" style="background-color: #FA8072;">NOME</td>
                <td class="titulo" style="background-color: #D2691E;">EMAIL</td>
                <td class="titulo" style="background-color: #FFE4E1;">SENHA</td>
        
            </tr>
            <?php 
            $sql = "SELECT * FROM tblogin";
            $comando = $conexao->prepare($sql);
            $comando-> execute();
            $usuarios = $comando->fetchAll();
            foreach($usuarios as $usuario){ ?>
            <tr>
                <td><?=$usuario["id"]?></td>
                <td><?=$usuario["nome"]?></td>
                <td><?=$usuario["email"]?></td>
                <td><?=$usuario["senha"]?></td>
                <?php } ?>
            </tr>
        
        </table>
    </div>
    
</body>
</html>