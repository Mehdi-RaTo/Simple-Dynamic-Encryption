import random

class SimpleDynamicEncryption:
    @staticmethod
    def Encode(strInput):
        rand = random.randint(1, 9)

        result = ""
        for char in strInput:
            result += chr(ord(char) + rand + 2)

        result += chr(rand + 33)

        return result

    @staticmethod
    def Decode(strInput):
        rand = ord(strInput[-1]) - 33

        strInput = strInput[:-1]

        result = ""
        for char in strInput:
            result += chr(ord(char) - rand - 2)

        return result

# Example usage:
input_string = "Mehdi-RaTo"
encoded_string = SimpleDynamicEncryption.Encode(input_string)
decoded_string = SimpleDynamicEncryption.Decode(encoded_string)

print("Original: ", input_string)
print("Encoded:  ", encoded_string)
print("Decoded:  ", decoded_string)
