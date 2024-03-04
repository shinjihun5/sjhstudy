package org.example;

import java.util.Arrays;
import java.util.List;

public class Main9 {

    public static void main(String[] args) {
        List<String> list = Arrays.asList("box","robot","simple");

        String result = list.stream()
                .reduce("aaaaaaa",(s, s2) -> {
                    if (s.length() > s2.length())
                        return s;
                    else
                        return s2;
                });
        System.out.println(result);



    }

}
