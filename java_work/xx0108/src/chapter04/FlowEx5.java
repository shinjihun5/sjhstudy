package chapter04;
import java.util.*;

class FlowEx5 {
	public static void main(String[] args) { 
		int  score = 0;
		char grade = ' ';
		char opt   = '0';


		Scanner scanner = new Scanner(System.in);
		String tmp = scanner.nextLine(); // ȭ���� ���� �Է¹��� ������ tmp�� ����
		score = Integer.parseInt(tmp);   // �Է¹��� ���ڿ�(tmp)�� ���ڷ� ��ȯ
		
		System.out.printf("", score);

		if (score >= 90) {		      // score�� 90�� ���� ���ų� ũ�� A����(grade)
			grade = 'A';
			if (score >= 98) { 	      // 90�� �̻� �߿����� 98�� �̻��� A+
				opt = '+';	
			} else if (score < 94) {  // 90�� �̻� 94�� �̸��� A-
				opt = '-';
			}
		} else if (score >= 80){	  // score�� 80�� ���� ���ų� ũ�� B����(grade)
			grade = 'B';
			if (score >= 88) {
				opt = '+';
			} else if (score < 84)	{
				opt = '-';
			}
		} else {				      // �������� C����(grade)
			grade = 'C';
		}
		// opt가 0일때는 opt 출력하지마라
		if(opt =='0')
			System.out.println(grade);
		else
		System.out.println(grade+""+opt);
	
	}
}
