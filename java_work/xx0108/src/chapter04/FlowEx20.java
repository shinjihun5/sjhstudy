package chapter04;


class FlowEx20 {
	public static void main(String[] args) { 
		// i=1일때 j는 1~5 , i가 5될때까지 반복
		for(int i=1;i<=5;i++) { 
			for(int j=1;j<=16;j=j+3) {
			if( i==j ) {
				System.out.printf("[%d,%d]", i, j);
		}   else {
			System.out.printf("\t");
			System.out.printf("%d ", ' ');
			}
				
				
				
				//System.out.printf("[%d,%d]", i, j);			
				// System.out.println("["+i+","+j+"]");
			}
			System.out.println();
		}
	} // main�� ��
}
