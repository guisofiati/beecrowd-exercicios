import java.util.Locale;
import java.util.Scanner;

public class beecrowd1002 {

	public static void main(String[] args) {
		
		Locale.setDefault(Locale.US);
		Scanner sc = new Scanner(System.in);
		
		double area, raio;
		
		raio = sc.nextDouble();
		
		area = Math.pow(raio, 2) * 3.14159;
		
		System.out.println("A=" + String.format("%.4f", area));
		
		sc.close();
	}
}
