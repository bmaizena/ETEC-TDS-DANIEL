<?php

echo "<h1>Arquivo receber dados</h1>";

echo "<PRE>";
print_r ($_POST);
echo "</PRE>";

echo "<hr>";

echo "Nome: " . $_POST['txtNome'];
echo "<br>";
echo "Idade: " . $_POST['txtIdade'];
echo "<br>";
echo "Senha: " . $_POST['txtSenha'];