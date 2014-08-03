import java.util.Scanner;


public class _07_CountSubstringOccurrences {

	public static void main(String[] args) {
		Scanner input = new Scanner(System.in);
		//Read text
		String line=input.nextLine().toLowerCase();
		//String[] words=line.split("\\W+");
		
		//read word
		int repeats =0;
		String word=input.next().toLowerCase();
		
		for (int i = 0; i <= line.length()-word.length(); i++) {
			if ((line.substring(i, i + word.length()).equals(word))) {
				repeats++;
			}
		}
		//Print
		System.out.println(repeats);

	}

}
