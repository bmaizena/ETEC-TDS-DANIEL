<?php



if (isset($_POST['txtEmail']) && isset($_POST['txtSenha']) && isset($_POST['txtNome'])){

    $email =$_POST['txtEmail'];
    $senha = password_hash ($_POST['txtSenha'], PASSWORD_DEFAULT);
    $nome =$_POST['txtNome'];

    require_once('../conexao.php');
    $sql = "INSERT INTO tblogin (email, senha, nome) VALUES (:email, :senha, :nome)";

    $comando = $conexao->prepare($sql);
    $comando->bindValue(":email", $email, PDO::PARAM_STR);
    $comando->bindValue(":senha", $senha, PDO::PARAM_STR);
    $comando->bindValue(":nome", $nome, PDO::PARAM_STR);

    if($comando->execute()){
        header('location: ./frmCadUser.php');
    }
}
else{
    header('location: ../index.php');
}


