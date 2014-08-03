import java.util.Scanner;


public class PointsInsideTheHouse {

	public static void main(String[] args) {
		Scanner input = new Scanner(System.in); 
		//Point
		System.out.print("Enter point: "); 
		float x = input.nextFloat();
		float y = input.nextFloat();
		
		//If A=A1+A2+A3 => point is inside of triangle
		float A= area(12.5f, 8.5f, 22.5f, 8.5f, 17.5f, 3.5f);
		float A1= area(x, y, 22.5f, 8.5f, 17.5f, 3.5f);
		float A2= area(12.5f, 8.5f, x, y, 17.5f, 3.5f);
		float A3= area(12.5f, 8.5f, 22.5f, 8.5f, x, y);
		
		//Check triangle
		if (A==A1+A2+A3) {
			System.out.println("Inside");
		}
		//Check first rectangle
		else if(x>=12.5&&x<=17.5&&y>=8.5&&y<=13.5){
			System.out.println("Inside");
		}
		//Check second rectangle
		else if (x>=20&&x<=22.5&&y>=8.5&&y<=13.5) {
			System.out.println("Inside");
		}
		else {
			System.out.println("Outside");
		}
	
	}

	private static float area(float x1, float y1, float x2, float y2, float x3, float y3) {
		
		float area= Math.abs((x1*(y2-y3) + x2*(y3-y1)+ x3*(y1-y2))/2.0f);
		return area;
		
	}
	
}
