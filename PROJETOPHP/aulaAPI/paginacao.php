<?php



if(isset($_GET['cmbApi'])) {
    $url = $_GET['cmbApi'];
    $curl = curl_init();
    curl_setopt($curl, CURLOPT_URL, $url);
    curl_setopt($curl, CURLOPT_RETURNTRANSFER, true);
    $response = curl_exec($curl);
    if(curl_errno($curl)) {
        $error_message = curl_error($curl);
        echo "Erro ao fazer a requisição: $error_message";
    }
    curl_close($curl);
    $lista = json_decode($response);

    $totalRegistro = count($lista);
    $registroPagina = $_GET['txtRegistroPagina'];

    $totalPaginas = 1;

    if ($totalRegistro % $registroPagina == 0) {
        $totalPaginas = ($totalRegistro/ $registroPagina);
    } else {
        $totalPaginas = ($totalRegistro / $registroPagina) +1;
    }

    $paginaSelecionada = 1;

    if(isset($_GET['paginaSelecionada'])){
        $paginaSelecionada = $_GET['paginaSelecionada'];
    }

    $ultimoRegistro = $paginaSelecionada * $registroPagina;
    $primeiroRegistroPagina = $ultimoRegistro - $registroPagina + 1;
    if ($ultimoRegistro > $totalRegistro){
        $ultimoRegistro = $totalRegistro;
    }


} else {
    header("location: index.php");
}


?>

<!DOCTYPE html>
<html lang="en">
<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>Document</title>
    <style>
        body {
            background-color: #D0D0D0
        }
    </style>
</head>
<body>
    <h1>Paginação Criada</h1>
    <hr>
    <div>
        <h2>Exibindo os registros da página: <?= $paginaSelecionada ?> </h2>
        <ul>
            <li>Primeiro Registro da Página: <?= $primeiroRegistroPagina ?></li>
            <li>Último Registro da Página <?= $ultimoRegistro ?></li>
        </ul>
    </div>

    <hr>

    <div>
        <h3>Lista dos Registros</h3>
        <?php
            for($i=$primeiroRegistroPagina; $i <= $ultimoRegistro; $i++) {
        ?>
            <p>Registro Número: <?=$i?>
            - ID: <?= $lista[$i - 1] -> id ?>
            - Municipio: <?= $lista[$i -1] -> nome ?>
        <?php    
            }
        ?>
    </div>

    <?php for($i = 1; $i <= $totalPaginas; $i++){ ?>
        <a href="?paginaSelecionada=<?= $i ?>&cmbApi=<?= $url?>&txtRegistroPagina=<?= $registroPagina?>"> <?= $i ?> - </a>
    <?php } ?>

    <hr>
    <a href="index.php">Voltar</a>

</body>
</html>