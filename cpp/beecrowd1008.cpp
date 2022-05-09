#include <iostream>
#include <iomanip>

using namespace std;

int main() {

    int codigo, horasTrabalhadas;
    double valorPorHora, salario;

    cin >> codigo >> horasTrabalhadas >> valorPorHora;

    salario = horasTrabalhadas * valorPorHora;

    cout << fixed << setprecision(2);
    cout << "NUMBER = " << codigo << endl;
    cout << "SALARY = U$ " << salario << endl;

    return 0;
}
