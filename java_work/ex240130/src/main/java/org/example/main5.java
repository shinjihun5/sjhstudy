package org.example;

import java.util.ArrayList;
import java.util.Arrays;
import java.util.Iterator;
import java.util.List;

public class main5 {
    public static void main(String[] args) {

        List<Integer> list = List.of(10,20,30);

        System.out.println(list);

        Iterator<Integer> itr = list.iterator();
        while (itr.hasNext()){
            int temp = itr.next();
            System.out.println(temp
            );
        }
        List<Integer> list2= new ArrayList<>(list);
        System.out.println(list2);

        list2.add(50);
        System.out.println(list2);

    }


}
