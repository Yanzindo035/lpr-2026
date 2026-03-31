#include <iostream>
using namespace std;

int main() {
    int numero;
    cout << "Digite um numero: ";
    cin >> numero;

    int quadrado = numero * numero;
    int soma = 0;

    while (quadrado > 0) {
        soma += quadrado % 10; 
        quadrado /= 10;         
    }

    cout << "Soma dos digitos do quadrado: " << soma << endl;
    
    return 0;
}