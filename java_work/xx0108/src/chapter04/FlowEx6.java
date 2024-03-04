package chapter04;
import java.util.*;

class FlowEx6 {
	public static void main(String[] args) { 
		int month = 0;

		System.out.print("");

		Scanner scanner = new Scanner(System.in);
		String tmp = scanner.nextLine(); // ȭ���� ���� �Է¹��� ������ tmp�� ����
		month = Integer.parseInt(tmp);   // �Է¹��� ���ڿ�(tmp)�� ���ڷ� ��ȯ

		switch(month) {
			case 3:
				System.out.println("3입니다");
				break;
			case 4: 
				System.out.println("4입니다");
			break;
			// break; 제일 가까이 있는 switch 구문이나 반복문을 탈출할떄 씁니다(for,while)
			
			case 5:
				System.out.println("5입니다");
				break;
			case 6: case 7: case 8:
				System.out.println("6, 7, 8입니다");
				break;
			case 9: case 10: case 11:
				System.out.println("9, 10, 11입니다");
			default:
				
	//		case 12:	case 1: case 2:
		}
		System.out.println("종료됩니다");
	} // main�� ��
}
