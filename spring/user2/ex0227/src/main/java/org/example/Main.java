package org.example;

import org.example.member.Member;
import org.example.Conf.MyConf;
import org.example.member.memberservice;
import org.springframework.context.annotation.AnnotationConfigApplicationContext;
import java.time.LocalDateTime;

public class Main {
    public static void main(String[] args) {


        AnnotationConfigApplicationContext context
                = new AnnotationConfigApplicationContext(MyConf.class);

        Member member1 = Member.builder()
                .email("aaa@naver.com")
                .password("1234")
                .name("홍길동")
                .wdate(LocalDateTime.now())
                .build();
        Member member2 = Member.builder()
                .email("bbb@naver.com")
                .password("5678")
                .name("김길동")
                .wdate(LocalDateTime.now())
                .build();
        memberservice memberService = context.getBean(memberservice.class);
        memberService.Regist(member2);
        memberService.Regist(member1);

        memberService.list();

//        String[] str = context.getBeanDefinitionNames();
    /*    int[] arr = {10,20,30,40,50};


        for(int temp : arr){
            System.out.println(temp);
        }
        Arrays.stream(arr).forEach(System.out::println);

        DateTimeFormatter formatter
                = DateTimeFormatter.ofPattern("yyyy년MM월dd일 hh:mm:ss");
        System.out.println(formatter.format(now));
    */
//        Arrays.stream(str).forEach(System.out::println);
        context.close();
    }
}