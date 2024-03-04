package chapter04;
class FlowEx31 {
	public static void main(String[] args) {
		for(int i=0;i <= 21;i++) {
			if (i%4==0)
	//			System.out.println("i+가 뒤일때 컨티뉴 됨");
				continue;
			// 배수 문제, if문의 값이 트루일때 컨티뉴 : 멈춤
			 System.out.println(i);
		}
	}
}
