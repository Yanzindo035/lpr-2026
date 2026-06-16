#include <iostream>

using namespace std;

int main() {
    float raio;
    float area;

    cout << "Digite o raio da circunferencia desejada: ";
    cin >> raio; 

    area = 3.14159 * (raio * raio);

    cout << "A area calculada eh: " << area << endl;

    return 0;
}


