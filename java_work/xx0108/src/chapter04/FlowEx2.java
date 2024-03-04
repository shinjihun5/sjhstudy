package chapter04;

import java.util.*; // ScannerŬ������ ����ϱ� ���� �߰�

class FlowEx2 {
	public static void main(String[] args) {
		int input;

		Scanner scanner = new Scanner(System.in);
		String tmp = scanner.nextLine(); // ȭ���� ���� �Է¹��� ������ tmp�� ����
		input = Integer.parseInt(tmp); // �Է¹��� ���ڿ�(tmp)�� ���ڷ� ��ȯ

		if (input == 0) {
			System.out.println("0을 입력했네요");
		}

		if (input != 0)
			System.out.println("0말고 다른 것을 입력했네요. " + input);
	} // main�� ��
}
