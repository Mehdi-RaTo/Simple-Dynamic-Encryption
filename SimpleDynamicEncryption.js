class SimpleDynamicEncryption {
    static Encode(strInput) {
        let rand = Math.floor(Math.random() * 9) + 1;

        let result = "";
        for (let i = 0; i < strInput.length; i++) {
            result += String.fromCharCode(strInput.charCodeAt(i) + rand + 2);
        }

        result += String.fromCharCode(rand + 33);

        return result;
    }

    static Decode(strInput) {
        let rand = strInput.charCodeAt(strInput.length - 1) - 33;

        strInput = strInput.substring(0, strInput.length - 1);

        let result = "";
        for (let i = 0; i < strInput.length; i++) {
            result += String.fromCharCode(strInput.charCodeAt(i) - rand - 2);
        }

        return result;
    }
}