import java.util.Scanner;
import java.util.regex.*;


public class _08_ExtractEmails {

	public static void main(String[] args) {
		Scanner input = new Scanner(System.in);
		//Read text
		String text=input.nextLine().toLowerCase();
		
		Pattern emailPattern = Pattern.compile(
				"[a-z]+[.-_]*[a-z]+@[a-z]+[-]*[.a-z]+[a-z]");
			Matcher matcher = emailPattern.matcher(text);
			while (matcher.find()) {
			    System.out.println(matcher.group());
			}

	}

}
