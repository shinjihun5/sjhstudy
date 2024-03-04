package org.example.Conf;

import org.example.member.MemberRepository;
import org.example.member.Memberservice;
import org.springframework.context.annotation.Bean;
import org.springframework.context.annotation.Configuration;

@Configuration


public class MyConf {


    @Bean
    public MemberRepository memberdao(){
        MemberRepository md = new MemberRepository();
        return md;
    }
    @Bean
    public Memberservice memberservice(){
        Memberservice ms = new Memberservice();
        ms.set
        return ms;
    }

}