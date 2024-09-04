<?php
define ('CONECTOR', 'mysql');
define ('HOST', 'localhost');
define ('PORT', '3306');
define ('DBNAME', 'bdsistema');
define ('CHARSET', 'utf8');
define ('USER', 'root');
define ('PASSWORD', '123456');

$opcoes = array(
    PDO::MYSQL_ATTR_INIT_COMMAND => 'SET NAMES UTF8',
    PDO::ATTR_PERSISTENT => TRUE
);

$pdo = new PDO(
    CONECTOR.
    ":host=". HOST .
    ";port=". PORT .
    ";dbname=". DBNAME . 
    ";charset=". CHARSET . ";",
    USER, PASSWORD, $opcoes);

//--------------------
$consulta = "SELECT * FROM tblogin";
$comando = $pdo->prepare($consulta);
$comando-> execute();
$usuarios = $comando->fetchAll();
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
            font-size:20px
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
            border: 1px solid black;
            width: 50%;
            margin: auto;
            padding: 20px;
            border-radius:10px;
            
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
            transition: 0.8s;
            transform: translateY(-2px);
        }

    </style>
</head>
<body>
    <main>
        <h1>Cadastro de Usuário</h1>
        
        <form action="receberCadastro.php" method="POST">
            <input type="text" name="txtEmail" id="txtEmail" required placeholder="Informe seu email">
            <br><br>
            <input type="password" name="txtSenha" id="txtSenha" required placeholder="Informe uma senha">
        
            <br><br>
        
            <input type="submit" value="Cadastrar" id="botaoCad">
        </form>
    </main>

    
    
    <h2>Lista de Usuarios</h2>
    <table border="1">
        
        <tr>
            <td class="titulo" style="background-color: #ebb2ce;">ID</td>
            <td class="titulo" style="background-color: #c2ebb2;">EMAIL</td>
            <td class="titulo" style="background-color: #ebe7b2;">SENHA</td>
            
        </tr>

        <?php foreach($usuarios as $usuario){ ?>
        <tr>
            <td>0<?=$usuario["id"]?></td>
            <td><?=$usuario["email"]?></td>
            <td><?=$usuario["senha"]?></td>
            <?php } ?>
        </tr>
        
    </table>
    
</body>
</html>