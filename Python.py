import random

def Encode(strInput):
    rndInt = random.randint(1, 9)

    result = ""
    for char in strInput:
        result += chr(ord(char) + rndInt + 2)

    result += chr(rndInt + 33)

    return result

def Decode(strInput):
    rndInt = ord(strInput[-1]) - 33

    strInput = strInput[:-1]

    result = ""
    for char in strInput:
        result += chr(ord(char) - rndInt - 2)

    return result

# Example usage:
input_string = "Mehdi-RaTo"
encoded_string = Encode(input_string)
decoded_string = Decode(encoded_string)

print("Original: ", input_string)
print("Encoded:  ", encoded_string)
print("Decoded:  ", decoded_string)