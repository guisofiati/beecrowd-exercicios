#include <stdio.h>
#include <math.h>

// pi = M_PI

int main() {

    double area, raio;

    scanf("%lf", &raio);

    area = pow(raio, 2) * 3.14159;

    printf("A=%.4lf\n", area);

    return 0;
}
