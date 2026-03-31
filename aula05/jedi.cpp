#include <iostream>
using namespace std;

int main() {
    double horasPorDia;
    cout << "Digite as horas de treinamento por dia: ";
    cin >> horasPorDia;

    int dias = 0;
    double horasTotais = 0;

    while (horasTotais < 1000) {
        horasTotais += horasPorDia;
        dias++;

        if (dias % 7 == 6 || dias % 7 == 0) {
            horasTotais -= horasPorDia;
        }
    }

    double semanas = dias / 7.0;
    double meses = semanas / 4.5;

    cout << "\nTotal de dias: " << dias << endl;
    cout << "Total de semanas: " << semanas << endl;
    cout << "Total de meses: " << meses << endl;

    return 0;
}