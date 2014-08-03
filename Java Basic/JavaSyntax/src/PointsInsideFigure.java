import java.util.Scanner;


public class PointsInsideFigure {

	public static void main(String[] args) {
		Scanner input = new Scanner(System.in); 
		//Point
		System.out.print("Enter point: "); 
		float x = input.nextFloat();
		float y = input.nextFloat();

		//Check
		if ((x>=12.5)&&(x<=22.5)&&(y>=6)&&(y<=13.5)){
			if (!((x>=17.5)&&(x<=20)&&(y>=8.5))) {
				System.out.print("Inside");
			}
			else {
				System.out.print("Outside");
			}
		}
		else {
			System.out.print("Outside");
		}
		
	}

}
