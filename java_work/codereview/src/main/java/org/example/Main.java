package org.example;

import java.io.BufferedReader;
import java.io.IOException;
import java.io.InputStreamReader;
import java.util.ArrayList;
import java.util.Arrays;
import java.util.List;
import java.util.Random;
import java.util.concurrent.*;

public class Main {


    public static void main(String[] args) {
        PlayGame playgame = new PlayGame();

        try (BufferedReader reader = new BufferedReader(new InputStreamReader(System.in))) {
            boolean continueGame = true;

            while (continueGame) {
                System.out.println("난이도를 선택하세요: 쉬움(1), 보통(2), 어려움(3)");
                int difficulty = Integer.parseInt(reader.readLine());
                int timeLimit = 0;

                switch (difficulty) {
                    case 1:
                        timeLimit = 60;
                        break;
                    case 2:
                        timeLimit = 30;
                        break;
                    case 3:
                        timeLimit = 15;
                        break;
                    default:
                        System.out.println("잘못된 입력입니다. 기본값으로 쉬움이 선택됩니다.");
                        timeLimit = 60;
                        break;
                }

                System.out.println("선택된 난이도에 따라 " + timeLimit + "초 동안 맞춰보세요.");
                continueGame = playgame.playGame(timeLimit);

                if (continueGame) {
                    System.out.println("다시 시도하시겠습니까? (yes/no): ");
                    String response = reader.readLine();
                    continueGame = response.equalsIgnoreCase("yes");
                }
            }

            System.out.println("게임을 종료합니다. 수고하셨습니다!");
        } catch (IOException e) {
            e.printStackTrace();
        }
    }
}

class PlayGame {
    public boolean playGame(int timeLimit) {
        String[] animals = {"원숭이", "토끼", "얼룩말"};
        List<String> remainingAnimals = new ArrayList<>(Arrays.asList(animals));
        int totalAttempts = 0;
        int correctAttempts = 0;

        ExecutorService executor = Executors.newSingleThreadExecutor();

        try (BufferedReader reader = new BufferedReader(new InputStreamReader(System.in))) {
            while (!remainingAnimals.isEmpty()) {
                Random random = new Random();
                int randomIndex = random.nextInt(remainingAnimals.size());
                String selectedAnimal = remainingAnimals.get(randomIndex);

                String hint = getHint(selectedAnimal);
                System.out.println("힌트: " + hint);
                System.out.println("동물을 맞춰보세요.");

                long endTime = System.currentTimeMillis() + TimeUnit.SECONDS.toMillis(timeLimit);

                Future<String> userInput = executor.submit(() -> {
                    try {
                        return reader.readLine().trim();
                    } catch (IOException e) {
                        e.printStackTrace();
                        return null;
                    }
                });

                try {
                    String userGuess = userInput.get(timeLimit, TimeUnit.SECONDS);

                    if (userGuess != null && userGuess.equalsIgnoreCase(selectedAnimal)) {
                        System.out.println("정답입니다!");
                        remainingAnimals.remove(selectedAnimal);
                        correctAttempts++;
                    } else {
                        System.out.println("틀렸습니다. 다시 맞춰보세요.");
                    }
                } catch (TimeoutException e) {
                    System.out.println("시간 초과! 현재까지의 결과:");
                    System.out.println("총 시도 횟수: " + totalAttempts);
                    System.out.println("맞춘 문제 수: " + correctAttempts);
                    System.out.println("다시 시도하시겠습니까? (yes/no): ");
                    String response = reader.readLine();
                    if (response.equalsIgnoreCase("no")) {
                        return false;
                    } /*else {
                        remainingAnimals.clear();
                        break;
                    */
                } catch (InterruptedException | ExecutionException e) {
                    e.printStackTrace();
                }

                totalAttempts++;
            }
        } catch (IOException e) {
            e.printStackTrace();
        } finally {
            executor.shutdown();
        }

        System.out.println("게임 종료. 모든 동물을 맞추셨습니다!");
        System.out.println("총 시도 횟수: " + totalAttempts);
        System.out.println("맞춘 문제 수: " + correctAttempts);
        return true;
    }

    private String getHint(String animal) {
        switch (animal) {
            case "원숭이":
                return "바나나를 좋아한다";
            case "토끼":
                return "귀가 길다";
            case "얼룩말":
                return "줄무니가 있다";
            default:
                return "힌트 없음";
        }
    }
}