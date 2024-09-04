
<!DOCTYPE html>
<html lang="pt-br">
<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>Document</title>
    
</head>
<body>

<h1>Formulário Paginação</h1>

<form method="GET" action="paginacao.php">
    
    <select name="cmbApi" id="cmbApi" required>
        <option value="servicodados.ibge.gov.br/api/v1/localidades/estados">Lista de Estados</option>
        <option value="servicodados.ibge.gov.br/api/v1/localidades/municipios">Lista Municipios Brasileiros</option>
        <option value="servicodados.ibge.gov.br/api/v1/localidades/estados/35/municipios">Lista de Municipios UF: SP</option>
    </select>
    <input type="number" name="txtRegistroPagina" id="txtRegistroPagina" value="10">
    
    <br>

    <input type="submit" value="Gerar Paginação">
    <hr>
</form>
    
</body>
</html>