import java.util.Scanner;


public class _05_CountAllWords {

	public static void main(String[] args) {
		Scanner input = new Scanner(System.in);
		//Read line
		String line=input.nextLine();
		System.out.println(line.split("\\W+").length);
	}

}
