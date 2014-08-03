import java.util.Scanner;


public class DecimalToHexadecimal {

	public static void main(String[] args) {
		Scanner input = new Scanner(System.in); 
		System.out.print("Enter decimal num: "); 
		int num = input.nextInt();
		
		String hex = Integer.toHexString(num);
		System.out.println(hex);
	}

}
