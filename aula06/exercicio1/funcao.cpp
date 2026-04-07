#include <iostream>

int reverterInteiro(int n) {
    int reverso = 0;
    
    while (n != 0) {
        int ultimoDigito = n % 10;
        reverso = (reverso * 10) + ultimoDigito;
        n /= 10;
    }
    
    return reverso;
}

int main() {
    int num = 1234;
    std::cout << "Original: " << num << std::endl;
    std::cout << "Reverso: " << reverterInteiro(num) << std::endl;
    
    return 0;
}