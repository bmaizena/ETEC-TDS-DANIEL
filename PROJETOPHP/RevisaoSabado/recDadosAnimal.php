<?php

echo "<h1>Recebendo Dados dos Animais</h1>";

echo "<PRE>";
print_r ($_POST);
echo "<PRE>";

echo "O Animal é " . $_POST['txtAnimal']. "<br>";
echo "O Nome do Animal é " . $_POST['txtNome']. "<br>";
echo "A Idade do Animal é " . $_POST['numberIdade'] . " ANOS". "<br>";
echo "A Ultima vacina foi " . $_POST['dateVacina']. "<br>";
echo "O Peso do Animal é " . $_POST['numberPeso'];


?>