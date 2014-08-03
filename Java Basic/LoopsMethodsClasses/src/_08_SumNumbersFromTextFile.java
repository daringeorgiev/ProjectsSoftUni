import java.io.BufferedReader;
import java.io.FileReader;
import java.io.IOException;



public class _08_SumNumbersFromTextFile {

	public static void main(String[] args) {

		 try{
	         BufferedReader reader = new BufferedReader(new FileReader("input.txt"));
	         String line = null;
	         int sum = 0;
	         while ((line = reader.readLine()) != null) {
	             sum+=Integer.parseInt(line);
	         }
	         System.out.println(sum);
	     }
	     catch(Exception ex){
	             System.out.println("(missing file)");
	     }

	}

}
