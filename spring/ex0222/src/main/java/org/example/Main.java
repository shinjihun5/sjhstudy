package org.example;

import org.example.componont.AA;
import org.example.conf.AppContext;
import org.springframework.context.annotation.AnnotationConfigApplicationContext;

public class Main {
    public static void main(String[] args) {

        AnnotationConfigApplicationContext context =
                new AnnotationConfigApplicationContext(AppContext.class);

        AA a1 = context.getBean(AA.class);
        System.out.println(a1);

        AA a2 = context.getBean(AA.class);
        System.out.println(a1);

        System.out.println(a1.getClass());
        System.out.println(a2.getClass());
        System.out.println(a1==a2);



        context.close();

    }
}
