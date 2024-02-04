<?php

function Encode($strInput)
{
    $rand = mt_rand(1, 9);

    $result = "";
    for ($i = 0; $i < strlen($strInput); $i++) {
        $result .= chr(ord($strInput[$i]) + $rand + 2);
    }

    $result .= chr($rand + 33);

    return $result;
}

function Decode($strInput)
{
    $rand = ord($strInput[strlen($strInput) - 1]) - 33;

    $strInput = substr($strInput, 0, -1);

    $result = "";
    for ($i = 0; $i < strlen($strInput); $i++) {
        $result .= chr(ord($strInput[$i]) - $rand - 2);
    }

    return $result;
}

// Example usage:
$input_string = "Mehdi-RaTo";
$encoded_string = Encode($input_string);
$decoded_string = Decode($encoded_string);

echo "Original: $input_string\n";
echo "Encoded:  $encoded_string\n";
echo "Decoded:  $decoded_string\n";
