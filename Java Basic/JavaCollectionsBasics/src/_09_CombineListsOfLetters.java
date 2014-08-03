import java.util.ArrayList;
import java.util.Scanner;


public class _09_CombineListsOfLetters {

	public static void main(String[] args) {
		Scanner input = new Scanner(System.in);
		//Set lists
		ArrayList<Character> firstList = new ArrayList<>();
		ArrayList<Character> secondList = new ArrayList<>();
		
		for (char character : input.nextLine().toCharArray()) {
			firstList.add(character);
		}
		for (char character : input.nextLine().toCharArray()) {
			secondList.add(character);
		}
		//New list
		ArrayList<Character> result = new ArrayList<>();
		result.addAll(firstList);
		for (int i = 0; i < secondList.size(); i++) {
			if (!firstList.contains(secondList.get(i))) {
				result.add(' ');
				result.add(secondList.get(i));
			}
		}
		//Print
		for (char character : result) {
			System.out.print(character);
		}
	}

}
