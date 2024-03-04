package org.example;


import java.util.Arrays;

public class Main4 {
    public static void main(String[] args) {

        double[] ds = {1.1,2.2,3.3,4.4,5.5};

        Arrays.stream(ds).forEach(System.out::println);

        System.out.println();

        for (double temp : ds){
            System.out.println(temp);
        }


    }

}
