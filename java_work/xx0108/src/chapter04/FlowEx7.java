package chapter04;
import java.util.*;

class FlowEx7 {
	public static void main(String[] args) { 
		int user, com;

		System.out.print("");

		Scanner scanner = new Scanner(System.in);
		String tmp = scanner.nextLine(); 
		user = Integer.parseInt(tmp);
		// math.random()
		// o<x<1
		// o<x<3
		// 0.00000003 > 0
		// 2.9999999999999 > 2
		// com 1~3 중에 1,2,3, 3,2,1,
		// 1~100사이에 랜덤한 경우의 수 보여줘

		com = (int)(Math.random() * 3) + 1;  // 1,2,3�� �ϳ��� com�� �����
System.out.println(com);
System.out.println(user);
		
		switch(user-com) {
			case 2: case -1:
				System.out.println("user-com의 값은 2이거나 -1입니다");
				break;
			case 1: case -2:
				System.out.println("user-com의 값은 1이거나 -2입니다");
				break;
			case 0:
				System.out.println("user-com의 값은 0입니다");
				default:
					System.out.println("이쪽으로 옵니다");
	//			break;		// ������ �����̹Ƿ� break�� ����� �ʿ䰡 ����. 
		}
	} // main�� ��
}
