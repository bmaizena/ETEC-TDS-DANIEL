<!DOCTYPE html>
<html lang="pt-br">
<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>Document</title>
    <style>
        form {
            
            text-align: center
        }
    </style>
</head>
<body>

<h1>Formulário Paginação</h1>

<form method="GET"action="paginacao.php">
    
    <input type="number" name="txtTotalRegistros" id="txtTotalRegistros" value="100">
    <input type="number" name="txtRegistroPagina" id="txtRegistroPagina" value="10">

    <hr>
    
    <br>

    <input type="submit" value="Gerar Paginação">
    <hr>
</form>
    
</body>
</html>