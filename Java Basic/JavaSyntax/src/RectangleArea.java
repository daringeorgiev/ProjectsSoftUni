import java.util.Scanner;


public class RectangleArea {

	public static void main(String[] args) {
		Scanner input = new Scanner(System.in); 
		System.out.print("Enter rectangle side a: "); 
		int a = input.nextInt();
		System.out.print("Enter rectangle side b: "); 
		int b = input.nextInt();
		//Print and area
		System.out.print("Area is: ");
		System.out.println(a*b);

	}

}
