<?php

$alunos = [
   ["nome"=>"tone","ra"=> 234],
   ["nome"=>"dan","ra"=> 987],
   ["nome"=>"ester","ra"=> 490]
];

echo "<PRE>";
print_r($alunos);
echo "<PRE>";

echo  $alunos['alunoUm']['nome'] . " - " . $alunos['alunoUm']['ra'] . "<br>";
echo  $alunos['alunoDois']['nome'] . " - " . $alunos['alunoDois']['ra'] . "<br>";
echo  $alunos['alunoTres']['nome'] . " - " . $alunos['alunoTres']['ra'];

