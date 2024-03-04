package chapter5;

import java.lang.reflect.Array;
import java.util.Arrays;

class ArrayEx3{
	public static void main(String[] args) {
		int[] arr = new int[5];

		// for 구문으로 arr 입력
		for(int i=0; i < arr.length;i++) 
			arr[i] = i + 1;

		System.out.println("arr.length:"+arr.length);	
		for(int i=0; i < arr.length;i++) 
			System.out.println("arr["+i+"]:"+arr[i]);	
// tmp 배열 선언 5*2
		int[] tmp = new int[arr.length*2];

		// �迭 arr�� ����� ������ �迭 tmp�� �����Ѵ�.
		for(int i=0; i < arr.length;i++) 
			tmp[i] = arr[i];

		System.out.println(Arrays.toString(tmp));
		
		arr = tmp;  // tmp�� ����� ���� arr�� �����Ѵ�.

		System.out.println("������ - arr.length:"+arr.length);	
		for(int i=0; i < arr.length;i++) 
			System.out.println("arr["+i+"]:"+arr[i]);	
	}
}
