#include <iostream>

std::string Encode(std::string strInput) {
	std::srand(static_cast<unsigned int>(std::time(0)));
	int rndInt = std::rand() % 9 + 1;

	std::string result = "";
	for (char c : strInput) {
		result += static_cast<char>(c + rndInt + 2);
	}

	result += static_cast<char>(rndInt + 33);

	return result;
}

std::string Decode(std::string strInput) {
	int rndInt = strInput[strInput.length() - 1] - 33;

	strInput = strInput.substr(0, strInput.length() - 1);

	std::string result = "";
	for (char c : strInput) {
		result += static_cast<char>(c - rndInt - 2);
	}

	return result;
}

void main() {
	// Example usage:
	std::string input_string = "Mehdi-RaTo";
	std::string encoded_string = Encode(input_string);
	std::string decoded_string = Decode(encoded_string);

	std::cout << "Original: " << input_string << std::endl;
	std::cout << "Encoded:  " << encoded_string << std::endl;
	std::cout << "Decoded:  " << decoded_string << std::endl;
}