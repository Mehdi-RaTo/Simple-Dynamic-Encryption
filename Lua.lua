function Encode(strInput)
    local rndInt = math.random(1, 9)

    local result = ""
    for i = 1, string.len(strInput) do
        result = result .. string.char(string.byte(strInput, i) + rndInt + 2)
    end

    result = result .. string.char(rndInt + 33)

    return result
end

function Decode(strInput)
    local rndInt = string.byte(strInput, string.len(strInput)) - 33

    strInput = string.sub(strInput, 1, string.len(strInput) - 1)

    local result = ""
    for i = 1, string.len(strInput) do
        result = result .. string.char(string.byte(strInput, i) - rndInt - 2)
    end

    return result
end

-- Example usage:
local input_string = "Mehdi-RaTo"
local encoded_string = Encode(input_string)
local decoded_string = Decode(encoded_string)

print("Original: ", input_string)
print("Encoded:  ", encoded_string)
print("Decoded:  ", decoded_string)
