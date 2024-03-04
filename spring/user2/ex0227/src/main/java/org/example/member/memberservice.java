package org.example.member;

import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.stereotype.Component;

import java.util.Collection;
@Component
public class memberservice {

    @Autowired
    memberDAO memberdao;


    public void Regist(Member member){
        memberdao.insert(member);
    }
    public void list(){
        Collection<Member> collection = memberdao.select();
        collection.forEach(System.out::println);
    }}

