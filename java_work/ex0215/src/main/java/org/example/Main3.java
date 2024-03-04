package org.example;

import java.util.Arrays;
import java.util.stream.Stream;

public class Main3 {
    public static void main(String[] args) {

        String[] str = {"이","김","홍"};

        Stream<String> stream = Arrays.stream(str);

        // 1.
        Arrays.stream(str)
                .forEach(s -> System.out.println(s));

        System.out.println();

        // 2.
        Arrays.stream(str)
                .forEach(System.out::println);

        System.out.println();

        // 3.
        for (String temp : str){
            System.out.println(temp);
        }
    }
}
