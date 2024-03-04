package chapter04;
import java.util.*;

class FlowEx25 {
	public static void main(String[] args) { 
		int num = 0; 
		int sum = 0;

		System.out.print("숫자 입력 : 12345");
		Scanner scanner = new Scanner(System.in);
		String tmp = scanner.nextLine(); // ȭ���� ���� �Է¹��� ������ tmp�� ����
		num = Integer.parseInt(tmp);      // �Է¹��� ���ڿ�(tmp)�� ���ڷ� ��ȯ

		while(num!=0) {    
			// num�� 10���� ���� �������� sum�� ����
			sum += num%10; 	// sum = sum + num%10;
			System.out.println("sum = " + sum+" num = "+num);
			num = num/10;
			
		}
		
		System.out.println(""+ sum);
	}
}
