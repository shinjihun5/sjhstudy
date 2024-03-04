package chapter04;
import java.util.*;

class FlowEx32 {
	
	// 제곱 루트 로그 구하는 소스 식 
	public static void main(String[] args) { 
		int menu = 0;
		int num  = 0;

		Scanner scanner = new Scanner(System.in);

		while(true) {
			System.out.println("(1) square");
			System.out.println("(2) square root");
			System.out.println("(3) log");
			System.out.print("1,2,3중에 선택하세요");

			String tmp = scanner.nextLine(); // ȭ�鿡�� �Է¹��� ������ tmp�� ����
			menu = Integer.parseInt(tmp);    // �Է¹��� ���ڿ�(tmp)�� ���ڷ� ��ȯ

			if(menu==0) {
				System.out.println("종료됩니다");
				break;
			} else if (!(1 <= menu && menu <= 3)) {
				System.out.println("square square root 수행 0");
				continue;		
			}
			
			System.out.println("제곱 ="+ menu*menu);
			System.out.println("루트 ="+ Math.sqrt(menu));
			System.out.println("log ="+ Math.log10(menu));
		}
	} // main�� ��
}
