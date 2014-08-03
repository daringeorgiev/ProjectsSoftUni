import java.util.Scanner;


public class _05_AngleUnitConverter {

	public static void main(String[] args) {
		Scanner input = new Scanner(System.in);
		//Enter number
		System.out.print("Enter n:");
		int n=input.nextInt();
		//Arrays
		double[] angle= new double[n];
		String[] unit= new String[n];
		//Loop
		for (int i = 0; i < n; i++) {
			System.out.print("Enter angle: "); 
			angle[i] = input.nextDouble();
			unit[i]=input.next().intern();					
		}
		
		for (int j = 0; j < n; j++) {
			if (unit[j]=="rad") {
				radToDeg(angle[j]);
			}
			else if (unit[j]=="deg") {
				degToRad(angle[j]);
			}
			else {
				System.out.println("Error with unit");
			}
		}

	}

	private static void radToDeg(double num) {
		num=num*(180/Math.PI);
		System.out.printf("%.6f deg %n", num);
	}
	
	private static void degToRad(double num) {
		num=num*(Math.PI/180);
		System.out.printf("%.6f rad %n", num);
	}

}
