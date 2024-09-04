<?php
require_once('conexao.php');

$id =$_GET['id'];
$nome =$_POST['txtNome'];
$email =$_POST['txtEmail'];

$consulta = "UPDATE contatos SET nome = :nome, email=:email WHERE id=:id";

$comando = $pdo->prepare($consulta);
$comando->bindValue(":id", $id, PDO::PARAM_INT);
$comando->bindValue(":nome", $nome, PDO::PARAM_STR);
$comando->bindValue(":email", $email, PDO::PARAM_STR);
if($comando->execute()){
    header('location:/index.php');
}