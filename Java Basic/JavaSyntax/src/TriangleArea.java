import java.text.DecimalFormat;
import java.util.Scanner;


public class TriangleArea {

	public static void main(String[] args) {
		Scanner input = new Scanner(System.in); 
		//A
		System.out.print("Enter triangle point a: "); 
		int ax = input.nextInt();
		int ay = input.nextInt();
		
		//B
		System.out.print("Enter triangle point b: "); 
		int bx = input.nextInt();
		int by = input.nextInt();
		
		//C
		System.out.print("Enter triangle point c: "); 
		int cx = input.nextInt();
		int cy = input.nextInt();
		
		//Area
		double area=Math.abs((ax*(by-cy)+bx*(cy-ay)+cx*(ay-by))/2d);
		
		//Remove trailing zeroes
		DecimalFormat df = new DecimalFormat("###.###");
		  System.out.println(df.format(area));
		
	}

}
