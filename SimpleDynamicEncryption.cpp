#include <iostream>

class SimpleDynamicEncryption {
public:
	static std::string Encode(const std::string& strInput) {
		std::srand(static_cast<unsigned int>(std::time(0)));
		int rndInt = std::rand() % 9 + 1;

		std::string result = "";
		for (char c : strInput) {
			result += static_cast<char>(c + rndInt + 2);
		}

		result += static_cast<char>(rndInt + 33);

		return result;
	}

	static std::string Decode(const std::string& strInput) {
		int rndInt = strInput[strInput.length() - 1] - 33;

		std::string modifiedInput = strInput.substr(0, strInput.length() - 1);

		std::string result = "";
		for (char c : modifiedInput) {
			result += static_cast<char>(c - rndInt - 2);
		}

		return result;
	}
};