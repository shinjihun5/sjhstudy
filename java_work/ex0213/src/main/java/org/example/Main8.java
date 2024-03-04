package org.example;

import java.util.Arrays;
import java.util.List;
import java.util.function.Function;
import java.util.function.IntFunction;

public class Main8 {
    public static void main(String[] args) {
        Function<String, Integer> fn = s -> s.length();

        System.out.println(fn.apply("ROBOT"));
        System.out.println(fn.apply("SYSTEM"));

        System.out.println();

        List<String> list = Arrays.asList("ROBOT", "SYSTEM", "TEST");
        for (int i = 0; i < list.size(); i++) {
            System.out.println(list.get(i).length());
        }
        System.out.println();
    list.stream()
            .map(s -> s.length())
            .forEach(integer -> System.out.println(integer));
        IntFunction<String> StringIntFunction = value -> value+"";
        String result = StringIntFunction.apply(10);
        System.out.println(result);
    }
}
