
public class _03_FullHouse {

	public static void main(String[] args) {
			
		int sum=0;
		
		for (int i = 0; i < 13; i++) {
			for (int j = 0; j < 13; j++) {
				if (i!=j) {				
					printCard(i, j);
					sum+=24;
				}				;
			}
		}
		
		System.out.println(sum);
		
	}

	private static void printCard(int i, int j) {
		String[] number= new String[]{"2", "3", "4", "5", "6", "7", "8", "9", "10", "J", "Q", "K", "A"};
		String[] color= new String[] {"♣", "♦", "♥", "♠"};
		
		//First 3 cards
		for (int k = 0; k < color.length; k++) {
			for (int k2 = k+1; k2 < color.length; k2++) {
				for (int k3 = k2+1; k3 < color.length; k3++) {
					//Last 2 cards
					for (int l = 0; l < color.length; l++) {
						for (int l2 = l+1; l2 < color.length; l2++) {
							//print first 3
							System.out.print(number[i] + color[k]+number[i] + color[k2]+number[i] + color[k3]);
							//Print last 2
							System.out.println(number[j]+ color[l] + number[j] + color[l2]);
						}
					}
				}
			}
		}
		
	}

}
