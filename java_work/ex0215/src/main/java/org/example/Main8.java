package org.example;

import java.util.Arrays;
import java.util.List;

class toy{
    private String name;
    private int price;
    public toy(String name, int price) {
        this.name = name;
        this.price = price;
    }
    public int getPrice() {
        return price;
    }
}
public class Main8 {
    public static void main(String[] args) {
        List<toy> list =
                Arrays.asList(new toy("로봇",3000)
                ,new toy("총",5000)
                ,new toy("인형",10000));

    int sum = list.stream().filter(toy -> toy.getPrice()<10000)
                .mapToInt(value -> value.getPrice())
            .sum();
        System.out.println(sum);

        int sum1 = list.stream().filter(toy -> toy.getPrice()<10000)
                .mapToInt(value -> value.getPrice())
                        .reduce(0,((left, right) -> left+right));
        System.out.println(sum1);
    }
}
