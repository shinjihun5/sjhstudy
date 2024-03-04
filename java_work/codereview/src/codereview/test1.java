package codereview;

import java.util.ArrayList;
import java.util.Arrays;
import java.util.List;
import java.util.Random;
import java.util.Scanner;

public class test1 {

	private static String gethint(String animal) {
		switch(animal) {
		case "원숭이":
			return "바나나를 좋아하며 지능이 다른 동물에 비해 비교적 높다";
		case "토끼":
			return "귀가 길며 앞다리가 짧고 뒷다리는 길다.";
		case "얼룩말":
			return "몸에 아름다운 줄무니가 있다.";
		case "호랑이";
			return "고양이과 동물이며 산군이라는 별명도 있다";
		default:
			return "힌트 없음";	
		// switch문을 사용해 각각 동물들의 힌트를 설정
		}
	}
	
	public static void main(String[] args) {
	
		
		
		
		String[] animals = {"원숭이","토끼","얼룩말","호랑이"};
		List<String> remaininganimals = new ArrayList<>(Arrays.asList(animals));
		// remaininganimals이라는 리스트를 만들어 n마리의 동물들을 리스트에 복사
		int a = 0;
		
		while(!remaininganimals.isEmpty()) {
		//while 루프를 이용해 정답을 맞출때까지 반복
		
		//random이라는 객체를 생성	
		Random random = new Random();
		
		int randomindex = random.nextInt(remaininganimals.size());
		String selectedAnimals = remaininganimals.get(randomindex);
		//remaininganimals.size() < 이걸 사용해 동물 리스트 크기에 맞춰서
		// 3마리의 동물들중 무작위로 선택 = selectedanimals  
		// remaininganimals 동물 리스트
		
				
		
		String hint = gethint(selectedAnimals);
		System.out.println("힌트: "+ hint);
		//무작위로 선택된 동물의 gethint를 나오게 설정
		
		
		Scanner sc = new Scanner(System.in);
		System.out.println("동물을 맞춰보세요.");
		String userGuess = sc.nextLine();
		
		
		if(userGuess.equalsIgnoreCase(selectedAnimals)) {
			System.out.println("정답입니다.");
			remaininganimals.remove(selectedAnimals);
		} else {
			System.out.println("틀렸습니다. 다시 맞춰보세요.");
		}
		a++;
		// 정답 시도횟수 저장
	
		//맞출때까지 계속 반복하며 3마리 다 맞추면 2개의 문구 출력
	
		
		}
		
		System.out.println("다 맞추셨습니다 축하드립니다.");
		System.out.println("총 시도 횟수 = "+a++);
		
	
	}

	
}

		
	
