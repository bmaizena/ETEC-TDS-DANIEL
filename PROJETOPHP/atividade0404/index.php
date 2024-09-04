<?php

$lanches = ["x-tudo", "y-burger jacu", "mc-jacs"];

$porcoes = ["batata frita", "bananinhas fritas", "macaxeira"];

echo $porcoes[2];

echo "<hr>";

for ($i = 0; $i < count($lanches); $i++) {
    echo $lanches[$i] . "<br>";
}

echo "<hr>";

foreach($porcoes as $porcao) {
    echo $porcao . "<br>";
}

echo "<hr>";

$cardapios = [
    "lanches" => ['x-tudo',
    'y-burger jacu', 
    'mc-jacs'],

    "porcoes" => ['batata frita', 
    'bananinhas fritas', 
    'macaxeira']
];

echo "<PRE>";
print_r ($cardapios);
echo "</PRE>";

// ou var_dump($cardapio);

echo "<hr>";

foreach($cardapios as $cardapio){
    echo $cardapio[0] . "<br>" . $cardapio[1] . "<br>" . $cardapio[2] . "<br>";
}

