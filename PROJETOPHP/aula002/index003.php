<?php

$lojaCarros =[
    ["placa" => 'FDN7845', "modelo" => 'Megane', "ano" => '2024'],
    ["placa" => 'MDA6987', "modelo" => 'Celta', "ano" => '2009'],
    ["placa" => 'QEV9012', "modelo" => 'Rampage', "ano" => '2018'],
    ["placa" => 'PNC2354', "modelo" => 'Golf', "ano" => '1980']
];

echo "<PRE>";
print_r ($lojaCarros);
echo "<PRE>";

echo "<hr>";

echo "{$lojaCarros[0]['placa']} - {$lojaCarros[0]['modelo']} - {$lojaCarros[0]['ano']}" . "<br>";

echo "<hr>";

echo "Usando o FOR" . "<br>";

for ($i = 0 ; $i < count($lojaCarros); $i++) {

    echo "a placa do modelo {$lojaCarros[$i]['modelo']} é {$lojaCarros[$i]['placa']} e o ano dele é  {$lojaCarros[$i]['ano']}" . "<br>";
}

echo "<hr>";

echo "Usando o FOREACH" . "<br>";

foreach ($lojaCarros as $carro) {
    echo "a placa {$carro['placa']} é do carro {$carro['modelo']} e é do ano {$carro['ano']}" . "<br>";
}

echo "<hr>";
echo "Atividade 001" . "<br>";

$times = ["Arsenal","Palmeiras","City","Santos","Porto","River Plate"];

for ($i = 0 ; $i < count($times); $i++) {
    echo "o time {$i} é {$times[$i]}" . "<br>";
}

echo "<hr>";
echo "Atividade 002" . "<br>";

foreach($times as $time) {
    echo $time . "<br>";
}

echo "<hr>";
echo "Atividade 003" . "<br>";

$times = [
    ["nome" => 'Palmeiras', "tecnico" => 'Abel Ferreira', "estadio" => 'Allianz Park'],
    ["nome" => 'Arsenal', "tecnico" => 'Mikel Arteta', "estadio" => 'Emirates'],
    ["nome" => 'Nottingham Forest', "tecnico" => 'Nuno Espirito', "estadio" => 'City Ground'],
    ["nome" => 'Liverpool', "tecnico" => 'Jurgen Klopp', "estadio" => 'Anfield']
];

foreach ($times as $time) {
    echo "o nome do time é {$time['nome']}, o técnico é o {$time['tecnico']} e o estádio se chama {$time['estadio']}" . "<br>";
}