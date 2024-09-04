<?php
define ('CONECTOR', 'mysql');
define ('HOST', 'localhost');
define ('PORT', '3306');
define ('DBNAME', 'prjconexao');
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
$consulta = "SELECT * FROM contatos";
$comando = $pdo->prepare($consulta);
$comando-> execute();
$contatos = $comando->fetchAll();




?>


<!DOCTYPE html>
<html lang="pt-br">
<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>Inicializando Conexôes com Banco de Dados</title>
    <style>
        body{
            text-align: center;
            background-color:'red';
        }
        table {
            border-collapse: collapse;
            margin: auto;
            
        }
        td{
            border: 1px solid black;
            padding: 10px;
        }

        .titulo{
            font-weight: bold;
            font-size:18px
            
        }

        a{
            padding:7px;
        }


    </style>
</head>
<body>
    <h1>Conexão com BD - Cadastro Contatos</h1>
    <hr>
    <h2>Formulário Cadastro</h2>

    <form action="receberDadosCadastro.php" method="POST">
        <input type="text" name="txtNome" id="txtNome" required placeholder="Informe o Nome">
        <br><br>

        <input type="email" name="txtEmail" id="txtEmail" required placeholder="Informe o Email">
        <br><br>
      
        <input type="submit" value="Cadastrar agora">
    </form>

    <hr>

    <h2>Lista de Contatos Atualizada</h2>
    <table border="1">
        
        <tr>
            <td class="titulo">ID</td>
            <td class="titulo">NOME</td>
            <td class="titulo">EMAIL</td>
            <td class="titulo">AÇÕES</td>
        </tr>

        <?php foreach($contatos as $contato){ ?>
        <tr>
            <td><?=$contato["id"]?></td>
            <td><?=$contato["nome"]?></td>
            <td><?=$contato["email"]?></td>
            <td>
                <a href="receberDadosExcluir.php/?id=<?=$contato["id"]?>">Excluir</a> 

                <a href="editarDadosCadastro.php/?id=<?=$contato["id"]?>">Editar </a>
                

                <a href="#">Detalhar</a>
            </td>
            
            <?php } ?>
        </tr>
        
    </table>
    
</body>
</html>