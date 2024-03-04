package org.example;

import java.util.Arrays;
import java.util.List;
import java.util.stream.Stream;

public class Main7 {

    public static void main(String[] args) {

        List<String> list1 =
                Arrays.asList("box","robot","simple");
        Stream<Integer> is =
                list1.stream().map(s -> s.length());
        is.forEach(System.out::println);

        list1.stream().map(s -> s+s)
                .forEach(System.out::println);

        System.out.println(list1);

        person p1 = new person("최",27);
        person p2 = new person("신",27);
        person p3 = new person("김",30);
        person p4 = new person("이",35);

        List<person> list = Arrays.asList(p1,p2,p3,p4);
        list.stream().map(person -> person.getName())
                .forEach(System.out::println);

        for (person person:list){
            System.out.println(person.getName()+"입니다");
        }
        int sum = list.stream()
                .mapToInt(person -> person.getAge())
                .filter(integer -> integer > 29)
                .reduce(0,
                        ((integer, integer2)
                                -> integer+=integer2));
        System.out.println(sum);


    }
}
