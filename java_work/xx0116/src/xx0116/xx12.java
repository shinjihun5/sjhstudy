package xx0116;

public class xx12 {
	
	public static void main(String[] args) {
		
		int result = fact(5);
		System.out.println(result);
	}

	public static int fact(int num) {
		if( num>0) 
			return num * fact(num-1);
		else 
				return 1;
		}
		
	}
	

