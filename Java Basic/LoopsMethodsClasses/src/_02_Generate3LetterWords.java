import java.util.Scanner;


public class _02_Generate3LetterWords {

	public static void main(String[] args) {
		Scanner input = new Scanner(System.in);
		//Enter chars
		System.out.print("Enter charecters: "); 
		String text=input.next();
		
		char[] chars =  text.toCharArray();
		
		for (int i = 0; i < chars.length; i++) {
			for (int j = 0; j < chars.length; j++) {
				for (int j2 = 0; j2 < chars.length; j2++) {
					System.out.print(chars[i]);
					System.out.print(chars[j]);
					System.out.print(chars[j2] + " ");
				}
			}
		}
	}

}
