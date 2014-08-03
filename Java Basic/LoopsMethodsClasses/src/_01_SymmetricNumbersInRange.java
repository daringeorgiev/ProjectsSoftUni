import java.util.Scanner;


public class _01_SymmetricNumbersInRange {

	public static void main(String[] args) {
		
		Scanner input = new Scanner(System.in);
		//Enter number
		System.out.print("Enter int start number: "); 
		int startNum = input.nextInt();
		System.out.print("Enter int end number: "); 
		int endNum = input.nextInt();
		
		//Loop from startNum to ednNum
		for (int i = startNum; i <= endNum; i++) {
			
			//Make charArray form i
			char[] chars =  Integer.toString(i).toCharArray();
			
			//Check if there are only one digit
			if (chars.length==1) {
				System.out.print(i + " ");
			}
			//Check if number is symmetric
			else {
				int j=0;
				boolean symmetric=true;
				do {
					if (!(chars[j]==chars[chars.length-j-1])) {
						symmetric=false;
					}
					j++;
				} while (j==1);
				//Print symmetrick number
				if (symmetric) {
					System.out.print(i + " ");
				}				
			}
		}
	}

}
