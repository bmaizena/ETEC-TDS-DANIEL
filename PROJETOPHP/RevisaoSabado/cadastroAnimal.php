<!DOCTYPE html>
<html lang="en">
<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>Document</title>
    <style>
        body {
            background-color: #C0C0C0 ;
        }
        h1{
            text-align: center;
            font-size: 70px
        }
        form {
            border: 1px solid black;
            width: 350px;
            margin: auto;
            
            padding: 20px;
            border-radius: 10px;
            padding-right: 28px;
            background-color: #DCDCDC;
            box-shadow: 3px 3px 3px 4px gray;
        }
        #enviar {
            width: 300px;

        }

        input {
            font-size: 20px;
            border-radius: 5px;
            width: 100%
        }
        label {
            font-size: 25px
        }
        select {
            font-size: 20px;
        }
    </style>
</head>
<body>
    <h1>Cadastro de Animais/Pets</H1>
    <form action="recDadosAnimal.php" method="POST">

        <label for="txtAnimal">Animal:</label>
        <input type="text" name="txtAnimal" id="txtAnimal">

        <br> <br>

        <label for="txtNome">Nome do Animal:</label>
        <input type="text" name="txtNome" id="txtNome">

        <br> <br>

        <label for="txtIdade">Idade do Animal:</label>
        <input type="number" name="numberIdade" id="numberIdade">

        <br> <br>

        <label for="dateVacina">Última Vacina:</label> 
        <input type="date" name="dateVacina" id="dateVacina">
        

        <br> <br>

        <label for="numberPeso">Peso:</label>
        <select name="numberPeso">
            <option value="leve">até 10kg</option>
            <option value="médio">até 20kg</option>
            <option value="pesado">mais de 20kg</option>
        </select>

        <br> <br>

        <input type="submit" value="Enviar" id="enviar">

    </form>
    
</body>
</html>