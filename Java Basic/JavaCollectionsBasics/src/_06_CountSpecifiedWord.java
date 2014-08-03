import java.util.Scanner;


public class _06_CountSpecifiedWord {

	public static void main(String[] args) {
		Scanner input = new Scanner(System.in);
		//Read text
		String line=input.nextLine();
		String[] words=line.split("\\W+");
		
		//read word
		int repeats =0;
		String word=input.next();
		for (int i = 0; i < words.length; i++) {
			if (words[i].equalsIgnoreCase(word)) {
				repeats++;
			}
		}
		//Print
		System.out.println(repeats);
	}

}
