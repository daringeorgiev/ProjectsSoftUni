import java.util.Scanner;


public class CountOfBitsOne {

	public static void main(String[] args) {
		Scanner input = new Scanner(System.in);
		//Enter number
		System.out.print("Enter int a: "); 
		int a = input.nextInt();
		//To char array
		String Abin = Integer.toBinaryString(a);
		char[] bit = Abin.toCharArray();
		
		//Check		
		int repeats=0;
		for (int i = 0; i < bit.length; i++) {
			if (bit[i]=='1'){
				repeats++;
			}
		}

		System.out.println(repeats);

		
	}

}
