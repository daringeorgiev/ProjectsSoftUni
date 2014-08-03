import java.util.Scanner;


public class TheSmallestO3Numbers {

	public static void main(String[] args) {
		Scanner input = new Scanner(System.in); 
		//Numbers
		System.out.print("Enter 3 numbers:"); 
		float a = input.nextFloat();
		float b = input.nextFloat();
		float c = input.nextFloat();
		
		float min=a;
		if (b<min) {
			min=b;
		}
		if (c<min) {
			min=c;
		}
		//Replace floating point zeroes and print
		System.out.printf(Float.toString(min).replaceAll("\\.?0*$", ""));
	}

}
