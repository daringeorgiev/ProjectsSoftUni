import java.sql.Time;
import java.time.Duration;
import java.time.LocalDate;
import java.time.LocalDateTime;
import java.time.format.DateTimeFormatter;
import java.time.temporal.ChronoUnit;
import java.util.Scanner;


public class _07_DaysBetweenTwoDates {

	public static void main(String[] args) {
		Scanner input = new Scanner(System.in);
		//Enter dates
		System.out.print("Enter first date:");
		String firstDate= input.nextLine();
		System.out.print("Enter second date:");
		String secondDate= input.nextLine();
		
		//Parse;
		LocalDate date1 = LocalDate.parse(firstDate, DateTimeFormatter.ofPattern("d-MM-yyyy")
				);
		LocalDate date2 = LocalDate.parse(secondDate, DateTimeFormatter.ofPattern("d-MM-yyyy")
				);
		
		//Calc
		long days = ChronoUnit.DAYS.between(date1, date2);
		
		
		//Print
		System.out.println(days);

	}

}
