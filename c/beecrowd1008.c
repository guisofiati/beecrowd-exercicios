#include <stdio.h>

int main() {

    int codigo, horasTrabalhadas;
    double valorPorHora, salario;

    scanf("%d", &codigo);
    scanf("%d", &horasTrabalhadas);
    scanf("%lf", &valorPorHora);

    salario = horasTrabalhadas * valorPorHora;

    printf("NUMBER = %d\n", codigo);
    printf("SALARY = U$ %.2lf\n", salario);

    return 0;
}
