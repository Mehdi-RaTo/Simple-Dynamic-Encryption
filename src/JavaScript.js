function Encode(strInput) {
    let rndInt = Math.floor(Math.random() * 9) + 1;

    let result = "";
    for (let i = 0; i < strInput.length; i++) {
        result += String.fromCharCode(strInput.charCodeAt(i) + rndInt + 2);
    }

    result += String.fromCharCode(rndInt + 33);

    return result;
}

function Decode(strInput) {
    let rndInt = strInput.charCodeAt(strInput.length - 1) - 33;

    strInput = strInput.substring(0, strInput.length - 1);

    let result = "";
    for (let i = 0; i < strInput.length; i++) {
        result += String.fromCharCode(strInput.charCodeAt(i) - rndInt - 2);
    }

    return result;
}

// Example usage:
var input_string = "Mehdi-RaTo";
var encoded_string = Encode(input_string);
var decoded_string = Decode(encoded_string);

console.log("Original: ", input_string);
console.log("Encoded:  ", encoded_string);
console.log("Decoded:  ", decoded_string);