import java.util.LinkedHashMap;
import java.util.Map;
import java.util.Scanner;


public class _12_CardsFrequencies {

	public static void main(String[] args) {
		Scanner input = new Scanner(System.in);
		//Read text
		String text=input.nextLine().toLowerCase();
		String[] cards=text.split("[ ♥♣♦♠]+");
		
		//From LittleNinja's homework (SoftUni forum) 
		Map<String, Integer> cardsMap = new LinkedHashMap<String, Integer>();
		for (String card : cards) {
			Integer count = cardsMap.get(card);
			if (count == null) {
				count = 0;
			}
			cardsMap.put(card, count + 1);
		}
		for (Map.Entry<String, Integer> entry : cardsMap.entrySet()) {
			double precentage = (double) entry.getValue() * 100 / cards.length;
			System.out.printf("%s -> %.2f%%\n", entry.getKey(), precentage);
		}
		

	}

}
