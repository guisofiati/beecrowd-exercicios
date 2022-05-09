import java.util.Locale;
import java.util.Scanner;

public class beecrowd1008 {

	public static void main(String[] args) {
		
		Locale.setDefault(Locale.US);
		Scanner sc = new Scanner(System.in);
		
		double salario;
		
		int codigo = sc.nextInt();
		int horasTrabalhadas = sc.nextInt();
		double valorPorHora = sc.nextDouble();
		
		salario = horasTrabalhadas * valorPorHora;
		
		System.out.println("NUMBER = " + codigo);
		System.out.printf("SALARY = U$ %.2f\n", salario);

		sc.close();
	}
}