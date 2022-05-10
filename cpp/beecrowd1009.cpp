#include <iostream>
#include <iomanip>

using namespace std;

int main() {

    string nome;
    double salario, totalVendas, totalReceber;

    cin >> nome >> salario >> totalVendas;

    totalReceber = salario + totalVendas * 0.15;

    cout << fixed << setprecision(2);
    cout << "TOTAL = R$ " << totalReceber << endl;

    return 0;
}
