import java.util.Scanner;


public class CountOfEqualBitPairs {

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
		for (int i = 0; i < bit.length-1; i++) {
			if (bit[i]==bit[i+1]){
				repeats++;
			}
		}

		System.out.println(repeats);

	}

}
