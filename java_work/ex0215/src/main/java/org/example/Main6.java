package org.example;

import java.util.Arrays;
import java.util.List;

public class Main6 {

    public static void main(String[] args) {
        person p1 = new person("최",27);
        person p2 = new person("신",27);
        person p3 = new person("김",30);
        person p4 = new person("이",35);

        List<person> list = Arrays.asList(p1,p2,p3,p4);

        list.stream().filter(person -> person.getAge()==20)
                .forEach(System.out::println);

        System.out.println();
/*        for (person person : list) {
            if(person.getAge()==20)
                System.out.println(person);
  */      }

    }

