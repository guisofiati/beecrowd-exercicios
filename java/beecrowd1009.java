import java.util.Locale;
import java.util.Scanner;

public class beecrowd1009 {

	public static void main(String[] args) {
		
		Locale.setDefault(Locale.US);
		Scanner sc = new Scanner(System.in);
		
		String nome;
		double salario, totalVendas, totalReceber;
		
		nome = sc.nextLine();
		salario = sc.nextDouble();
		totalVendas = sc.nextDouble();
		
		totalReceber = salario + totalVendas * 0.15;
		
		System.out.printf("TOTAL = R$ %.2f\n", totalReceber);

		sc.close();
	}
}