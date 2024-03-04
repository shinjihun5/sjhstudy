package chapter04;
import java.util.*;

class FlowEx8 {
	public static void main(String[] args) { 
		char gender = 0;
		String regNo = "";

	//	System.out.print(gender);
	//	System.out.print(regNo);
		Scanner scanner = new Scanner(System.in);
		regNo = scanner.nextLine();

		gender = regNo.charAt(7); // �Է¹��� ��ȣ�� 8��° ���ڸ� gender�� ����

		switch(gender) {
			case '1':
				// System.out.println("");
			case '3':
				System.out.println("남자입니다");
				break;
			case '2':
			case '4':
				break;
			default:
				System.out.println("YTYT");;
		}
	} // main�� ��
}
