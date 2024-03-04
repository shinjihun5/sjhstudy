package org.example;

import java.util.ArrayList;
import java.util.Arrays;
import java.util.List;
import java.util.Random;
import java.util.Scanner;

public class AnimalGuessingGame {

    private static String getHint(String animal) {
        switch (animal) {
            case "원숭이":
                return "바나나를 좋아하며 지능이 다른 동물에 비해 비교적 높다";
            case "토끼":
                return "귀가 길며 앞다리가 짧고 뒷다리는 길다.";
            case "얼룩말":
                return "몸에 아름다운 줄무니가 있다.";
            case "호랑이":
                return "고양이과 동물이며 산군이라는 별명도 있다";
            case "닭":
                return "매일 아침 해가 뜰때쯤 우는 동물이며 우리에게 많은 것을 가져다준다.";
            default:
                return "힌트 없음";
        }
    }

    private static void playGame(Scanner scanner, int timeLimit) {
        String[] animals = {"원숭이", "토끼", "얼룩말", "닭", "호랑이"};
        List<String> remainingAnimals = new ArrayList<>(Arrays.asList(animals));
        int attempts = 0;

        long startTime = System.currentTimeMillis();
        long elapsedTime = 0;
        boolean gameOver = false;

        while (!remainingAnimals.isEmpty()) {
            Random random = new Random();
            int randomIndex = random.nextInt(remainingAnimals.size());
            String selectedAnimal = remainingAnimals.get(randomIndex);

            String hint = getHint(selectedAnimal);
            System.out.println("힌트: " + hint);
            System.out.println("동물을 맞춰보세요.");

            String userGuess = scanner.next();

            if (userGuess.equalsIgnoreCase(selectedAnimal)) {
                System.out.println("정답입니다.");
                remainingAnimals.remove(selectedAnimal);
            } else {
                System.out.println("틀렸습니다. 다시 맞춰보세요.");
            }
            attempts++;

            elapsedTime = System.currentTimeMillis() - startTime;
            int remainingTime = (int) ((timeLimit * 1000 - elapsedTime) / 1000);

            if (remainingTime <= 0) {
                System.out.println("시간 초과! 게임 종료.");
                gameOver = true;
                break;
            } else {
                System.out.println("남은 시간: " + remainingTime + "초");
            }
        }

        if (!gameOver) {
            System.out.println("다 맞추셨습니다. 축하드립니다");
        }
        System.out.println("총 시도 횟수 = " + attempts);
        System.out.println("남은 시간 : " + (timeLimit - elapsedTime / 1000) + "초");

      /*  System.out.println("다시 시도하겠습니까? (yes/no)");
        String restart = scanner.next();

        if (!restart.equalsIgnoreCase("yes")) {
            System.out.println("게임을 종료합니다.");
     */
        }


    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);

        while (true) {
            System.out.println("난이도를 선택하세요. (1: 쉬움, 2: 보통, 3: 어려움)");
            int difficulty = scanner.nextInt();

            int timeLimit;
            switch (difficulty) {
                case 1:
                    timeLimit = 60;
                    break;
                case 2:
                    timeLimit = 30;
                    break;
                case 3:
                    timeLimit = 3;
                    break;
                default:
                    System.out.println("올바른 난이도를 선택하세요.");
                    return;
            }

            playGame(scanner, timeLimit);

            System.out.println("다시 시도하겠습니까? (yes/no)");
            String restart = scanner.next();

            if (!restart.equalsIgnoreCase("yes")) {
                System.out.println("게임을 종료합니다.");
                break;  // 루프를 빠져나가면서 프로그램 종료
            }
        }

        scanner.close();
    }
}