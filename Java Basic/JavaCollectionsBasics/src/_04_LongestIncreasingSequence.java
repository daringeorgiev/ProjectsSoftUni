import java.util.Scanner;


public class _04_LongestIncreasingSequence {

	public static void main(String[] args) {
		Scanner input = new Scanner(System.in);
		//Read line
		String line=input.nextLine();
		String[] words=line.split(" ");
		int[] num=new int[words.length];
		for (int i = 0; i < words.length; i++) {
			num[i]=Integer.parseInt(words[i]);
		}
		
		
		
		int index=0;
		int sum=1;
		int max=1;
		System.out.print(num[0] + " ");
		for (int i = 1; i < words.length; i++) {
			//Check equals
			if (num[i]>num[i-1]) {		
				sum++;
				System.out.print(num[i]+" ");
				if (sum>max) {
					index=i;
					max=sum;
				}
			}
			else {
				sum=1;
				System.out.println();
				System.out.print(num[i]+" ");
				
			}
		}
		//Print
		System.out.println();
		System.out.print("Longest: ");
		//System.out.println();
		for (int i = index-max+1; i <=index; i++) {
			System.out.print(num[i] + " ");			
		}

	}

}
