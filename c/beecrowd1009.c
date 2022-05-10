#include <stdio.h>

int main() {

    char nome[50];
    double salario, totalVendas, totalReceber;

    scanf("%s", nome);
    scanf("%lf", &salario);
    scanf("%lf", &totalVendas);

    totalReceber = salario + totalVendas * 0.15;

    printf("TOTAL = R$ %.2lf\n", totalReceber);

    return 0;
}
