package org.example;

import java.util.ArrayList;
import java.util.Arrays;
import java.util.List;
import java.util.stream.Collector;
import java.util.stream.Collectors;

public class Main2 {
    public static void main(String[] args) {

        List<String> list = Arrays.asList("robot","box","toy","sample");
        list = new ArrayList<>(list);
        List<String> clist = Arrays.asList("robot","box","toy","sample");
        clist = new ArrayList<>(clist);

        list.addAll(clist);
        System.out.println(list);

        List<String> list2 = new ArrayList<>();
        for (String temp :list){
            if (temp.length() > 3)
                list2.add(temp);
        }   System.out.println(list2);
        List streamlist = list.stream()
                .filter(s -> s.length()>3)
                .collect(
                        ()-> new ArrayList<>(),
                        (lst,s)->lst.add(s),
                        (lst1,lst2)-> lst1.addAll(list2));
        System.out.println(streamlist);

        List streamlist1 = list.stream()
                .filter(m -> m.length()>3)
                .collect(
                        Collectors.toList());
        System.out.println(streamlist1);
    }
}
