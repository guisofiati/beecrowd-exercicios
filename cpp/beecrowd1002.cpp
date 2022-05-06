#include <iostream>
#include <math.h>
#include <iomanip>

using namespace std;

int main() {

    double area, raio;

    cin >> raio;

    area = pow(raio, 2) * 3.14159;

    cout << fixed << setprecision(4);
    cout << "A=" << area << endl;

    return 0;
}
