import java.util.Scanner;


public class _03_LargestSequenceOfEqualStrings {
	public static void main(String[] args) {
		Scanner input = new Scanner(System.in);
		//Read line
		String line=input.nextLine();
		String[] words=line.split(" ");
		
		String result=words[0];
		int sum=1;
		int max=1;
		for (int i = 0; i < words.length-1; i++) {
			//Check equals
			if (words[i].equals(words[i+1])) {		
				sum++;
				if (sum>max) {
					result=words[i];
					max=sum;
				}
			}
			else {
				sum=1;
			}
		}
		//Print
		for (int i = 0; i < max; i++) {
			System.out.print(result + " ");			
		}
	}
}
