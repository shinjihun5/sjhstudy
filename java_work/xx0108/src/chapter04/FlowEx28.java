package chapter04;
import java.util.*;

class FlowEx28 {
	public static void main(String[] args) { 
		int input  = 0;
		int answer = 0;

		answer = (int)(Math.random() * 100) + 1; // 1~100������ ������ ���� ����
		Scanner scanner = new Scanner(System.in);

		do {
			System.out.print(">>>>>");

			String tmp = scanner.nextLine();
			input = Integer.parseInt(tmp);

			if(input > answer) {
				System.out.println("down");	
			} else if(input < answer) {
				System.out.println("up");			
			}
		} while(input!=answer);

		System.out.println("종료");
	}
}
