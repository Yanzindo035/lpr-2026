#include <iostream>
#include <iomanip>
using namespace std;
void calcularSomaImparesMultiplos3(int inicio, int fim) {
    int soma = 0;
    for (int i = inicio; i <= fim; i++) {
        if (i % 2 != 0 && i % 3 == 0) {
            soma += i;
        }
    }
    cout << "\nA soma dos numeros impares multiplos de 3 entre " << inicio << " e " << fim << " eh: " << soma << endl;
}

void calcularSomaDigitosQuadrado(int numero) {
    int quadrado = numero * numero;
    cout << "\n" << numero << " ao quadrado eh: " << quadrado << endl;

    int soma = 0;
    int aux = quadrado;
    while (aux > 0) {
        soma += aux % 10;
        aux /= 10;
    }
    cout << "A soma dos digitos de " << quadrado << " eh: " << soma << endl;
}

void calcularMediaParesUsuario(int quantidadeTotal) {
    int numero;
    int somaPares = 0;
    int contadorPares = 0;

    for (int i = 0; i < quantidadeTotal; i++) {
        cout << "Digite um numero: ";
        cin >> numero;

        if (numero % 2 == 0) {
            somaPares += numero;
            contadorPares++;
        }
    }

    if (contadorPares > 0) {
        double media = (double)somaPares / contadorPares;
        cout << fixed << setprecision(2);
        cout << "\nA media dos numeros pares digitados eh: " << media << endl;
    } else {
        cout << "\nNenhum numero par foi digitado." << endl;
    }
}

int main() {
    int opcao;
    do {
        cout << "\n--- MENU DE EXERCICIOS ---" << endl;
        cout << "1. Soma impares multiplos de 3 (50 a 500)" << endl;
        cout << "2. Quadrado e Soma dos Digitos" << endl;
        cout << "3. Media de numeros pares" << endl;
        cout << "Escolha uma opcao: ";
        cin >> opcao;

        switch (opcao) {
            case 1:
                calcularSomaImparesMultiplos3(50, 500);
                break;
            case 2: {
                int n;
                cout << "Digite um numero inteiro: ";
                cin >> n;
                calcularSomaDigitosQuadrado(n);
                break;
            }
            case 3: 
                int qtd;
                cout << "Digite a quantidade de numeros a inserir: ";
                cin >> qtd;
                calcularMediaParesUsuario(qtd);
                break;
            default:
                cout << "Opcao invalida!" << endl;
        }

    } while (opcao != 0);

    return 0;
}