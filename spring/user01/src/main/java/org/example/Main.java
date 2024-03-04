package org.example;

import org.example.Conf.MyConf;
import org.example.member.MemberDto;
import org.example.member.Memberservice;
import org.springframework.context.annotation.AnnotationConfigApplicationContext;

public class Main {
    private static AnnotationConfigApplicationContext acac = null;

    public static void main(String[] args) {
        // insert User 등록
        // list User 조회
        acac = new AnnotationConfigApplicationContext(MyConf.class);
        processNewCommand();
        processListCommand();
    }

    private static void processListCommand() {
        Memberservice ms = acac.getBean(Memberservice.class);
        ms.list();
    }

    private static void processNewCommand() {
        Memberservice ms = acac.getBean(Memberservice.class);

        MemberDto md = MemberDto.builder()
                .email("aaa@naver.com")
                .name("홍길동")
                .password("1234")
                .confirmPassword("1234")
                .build();

        if(!md.isEqualpassword()){
            System.out.println("비밀번호 틀렸다");
            return;
        }

        ms.regist(md);
    }
}