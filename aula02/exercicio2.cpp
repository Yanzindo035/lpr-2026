#include <iostream>

using namespace std;

int main() {
    int n1;
    int n2;
    int n3;
    int n4;
    int resposta;

    cout << "Digite o primeiro numero: ";
    cin >> n1;
    
    cout << "Digite o segundo numero: ";
    cin >> n2;

    cout << "Digite o terceiro numero: ";
    cin >> n3;

    cout << "Digite o quarto numero: ";
    cin >> n4;

    resposta = (n1 * n2) - (n3 * n4);

    cout << "A diferenca calculada eh: " << resposta << endl;

    return 0;
}