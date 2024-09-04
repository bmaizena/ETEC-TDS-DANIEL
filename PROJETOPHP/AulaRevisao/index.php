<?php 

$animais = ["ornitorrinco", "dragão-de-komodo", "calopsita", "chinchila"];

echo $animais[0] . "<br>". $animais[1] . "<br>" .$animais[2] . "<br>". $animais[3]. "<br>";

$animais[] = 'zebra';
$animais[] = 'bagre';
$animais[] = 'jumento';
$animais[] = 'pato';
$animais[] = 'pintinho';
$animais[] = 'tilapia';
$animais[] = 'esquilo';
$animais[] = 'dinossauro';
$animais[] = 'girino';
$animais[] = 'louva-deus';
$animais[] = 'grilo';
$animais[] = 'peru';
$animais[] = 'macaco';
$animais[] = 'chipanzé';
$animais[] = 'orangotango';
$animais[] = 'boi';
$animais[] = 'mariposa';
$animais[] = 'elefante';
$animais[] = 'girafa';
$animais[] = 'porco';
$animais[] = 'papagaio';
$animais[] = 'galo';

echo "<PRE>";
print_r($animais);
echo "<PRE>";

echo "<hr>";

$animais[2] = 'BEMTEVI';
$animais[10] = 'BÚFALO';
$animais[15] = 'BALEIA';

echo "<PRE>";
print_r($animais);
echo "<PRE>";

echo "<hr>";

echo "quantos elemntos tem no array animais?". "<br>";

echo count($animais);

echo "<hr>";

/*unset ($animais[4], $animais[8], $animais[9], $animais[11], $animais[14], $animais[22], $animais[23], $animais[1], $animais[24]);

echo "<PRE>";
print_r($animais);
echo "<PRE>";

echo "<hr>";

array_splice ($animais, 0, 0);

echo "<PRE>";
print_r($animais);
echo "<PRE>";

echo "<hr>";*/


for($i=1; $i < count($animais); $i+=5){
    echo "o animal na posição " . $i . " é " . $animais[$i] . "<br>";
};

