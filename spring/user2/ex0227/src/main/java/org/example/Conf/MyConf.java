package org.example.Conf;


import org.example.member.memberDAO;
import org.example.member.memberservice;
import org.example.component.AA;
import org.example.component.AABBService;
import org.springframework.context.annotation.Bean;
import org.springframework.context.annotation.ComponentScan;
import org.springframework.context.annotation.Configuration;

@ComponentScan({"org.example.member"})
@Configuration
public class MyConf {

    //    @Bean
    //    public org.example.user.MemberService memberService(){
    //    return new org.example.user.MemberService();


    @Bean
    public org.example.member.memberservice memberService(){
        return new memberservice();
    }
    @Bean
    public memberDAO memberdao(){ return new memberDAO(); }
    @Bean
    public AABBService aabbService(){
        return new AABBService();
}
    @Bean
    public AA aa(){ return new AA(); }
}
