package xx0116;

public class xx11 {
public static void main(String[] args) {
	
	System.out.println(doAdd(10,20));	
	System.out.println(divide(5,4));	
	System.out.println(divide(10,0));	

}
	
public static int doAdd(int num1, int num2) {
	int result = num1+num2;
	return result;
}


public static int divide(int num1, int num2) {
	
	if(num2 == 0) {
		System.out.println("0으로 나눌 수 없습니다.");
		return 1;
	}
	int result = num1/num2;
	return result;
	
	}
			
}


