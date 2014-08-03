import java.util.ArrayList;
import java.util.Arrays;
import java.util.Scanner;


public class _10_ExtractAllUniqueWords {

	public static void main(String[] args) {
		Scanner input = new Scanner(System.in);
		//Read text
		String text=input.nextLine().toLowerCase();
		String[] allWords=text.split("\\W+");
		
		ArrayList<String> words = new ArrayList<>();
		//Sort array
		Arrays.sort(allWords);
		//Set first word in list
		words.add(allWords[0]);
		//Check equals
		for (int i = 1; i < allWords.length; i++) {
			if (!(allWords[i].equals(allWords[i-1]))) {
				words.add(allWords[i]);
			}
		}
		//Print
		for (String word : words) {
			System.out.print(word + " ");
		}

	}

}
