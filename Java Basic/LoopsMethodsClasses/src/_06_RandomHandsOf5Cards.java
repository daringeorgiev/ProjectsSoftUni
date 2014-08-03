import java.util.Random;
import java.util.Scanner;


public class _06_RandomHandsOf5Cards {

	public static void main(String[] args) {
		Scanner input = new Scanner(System.in);
		//Enter number
		System.out.print("Enter n:");
		int n=input.nextInt();
		//Cards
		String[] number= new String[]{"2", "3", "4", "5", "6", "7", "8", "9", "10", "J", "Q", "K", "A"};
		String[] color= new String[] {"♣", "♦", "♥", "♠"};
		
		String[] card=new String[52];
		int index=0;
		
		for (int i = 0; i < number.length; i++) {
			for (int j = 0; j < color.length; j++) {
				card[index]=number[i]+color[j];
				index++;
			}
		}
		//Random
		Random rnd = new Random(); 
		
		int r1;
		int r2;
		int r3;
		int r4;
		int r5;
		for (int i = 0; i < n; i++) {
			do {
				r1=rnd.nextInt(52);
				r2=rnd.nextInt(52);
				r3=rnd.nextInt(52);
				r4=rnd.nextInt(52);
				r5=rnd.nextInt(52);
				
			} while (!((r1!=r2)&&(r1!=r3)&&(r1!=r4)&&(r1!=r5)&&(r2!=r3)&&(r2!=r4)&&(r2!=r5)&&(r3!=r4)&&(r3!=r5)&&(r4!=r5)));
			
			//Print
			System.out.print(card[r1]);
			System.out.print(card[r2]);
			System.out.print(card[r3]);
			System.out.print(card[r4]);
			System.out.print(card[r5]);
			System.out.println();
		}		
	}
}
