import java.util.ArrayList;
import java.util.Arrays;
import java.util.Scanner;
import java.util.TreeMap;


public class _11_MostFrequentWord {

	public static void main(String[] args) {
		Scanner input = new Scanner(System.in);
		//Read text
		String text=input.nextLine().toLowerCase();
		String[] allWords=text.split("\\W+");
		
		TreeMap<String, Integer> words = new TreeMap<>();
		//Sort array
		Arrays.sort(allWords);
		//Set first word in list
		words.put(allWords[0], 1);
		int repeats=1;
		int maxRep=1;
		//Check equals
		for (int i = 1; i < allWords.length; i++) {
			if (!(allWords[i].equals(allWords[i-1]))) {
				repeats=1;
				words.put(allWords[i], repeats);
			}
			else {
				repeats++;
				words.put(allWords[i], repeats);
			}
			if (repeats>maxRep) {
				maxRep=repeats;
			}
		}
		//Print
		for (String word : words.keySet()) {
			if (maxRep==words.get(word)) {
				System.out.println(word + " -> " + words.get(word));
			}
			
		}
	}

}
