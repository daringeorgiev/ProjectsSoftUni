import java.util.Scanner;


public class FormattingNumbers {

	public static void main(String[] args) {
		Scanner input = new Scanner(System.in);
		//Enter number
		System.out.print("Enter int a: "); 
		int a = input.nextInt();
		System.out.print("Enter int b: "); 
		float b = input.nextFloat();
		System.out.print("Enter int c: "); 
		float c = input.nextFloat();
		
		//Calculate hex and bin 
		String Ahex = Integer.toHexString(a);
		String Abin = Integer.toBinaryString(a);
		int A = Integer.parseInt(Abin);
		
		//Print
		System.out.printf("|%-10s|", Ahex);
		System.out.printf("%010d|", A);
		System.out.printf("%10.2f|", b);
		System.out.printf("%-10.3f|", c);
		
	}

}
