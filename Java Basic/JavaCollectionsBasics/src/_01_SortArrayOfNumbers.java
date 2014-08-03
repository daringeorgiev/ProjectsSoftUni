import java.util.Arrays;
import java.util.Scanner;



public class _01_SortArrayOfNumbers {

	public static void main(String[] args) {
		Scanner input = new Scanner(System.in);
		//Enter number
		System.out.print("Enter n:");
		int n=input.nextInt();
		int[] nums= new int[n];
		
		//Set elements
		for (int i = 0; i < n; i++) {
			System.out.print("Set element number " + (i+1) + ": ");
			nums[i]=input.nextInt();
		}
		//Sort
		Arrays.sort(nums);
		//Print
		for (int i = 0; i < nums.length; i++) {
			System.out.print(nums[i] + " ");
		}
	}

}
