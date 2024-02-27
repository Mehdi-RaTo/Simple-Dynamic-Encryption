function encode(strInput: string): string {
    const rndInt: number = Math.floor(Math.random() * 9) + 1;

    let result: string = "";
    for (let i = 0; i < strInput.length; i++) {
        result += String.fromCharCode(strInput.charCodeAt(i) + rndInt + 2);
    }

    result += String.fromCharCode(rndInt + 33);

    return result;
}

function decode(strInput: string): string {
    const rndInt: number = strInput.charCodeAt(strInput.length - 1) - 33;

    strInput = strInput.substring(0, strInput.length - 1);

    let result: string = "";
    for (let i = 0; i < strInput.length; i++) {
        result += String.fromCharCode(strInput.charCodeAt(i) - rndInt - 2);
    }

    return result;
}

// Example usage:
const inputString: string = "Mehdi-RaTo";
const encodedString: string = encode(inputString);
const decodedString: string = decode(encodedString);

console.log("Original: ", inputString);
console.log("Encoded:  ", encodedString);
console.log("Decoded:  ", decodedString);