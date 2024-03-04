package com.mh.mybatistest.member;

import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.web.bind.annotation.GetMapping;

public class membercontroller {
@Autowired
com.mh.mybatistest.member.memberRepository memberRepository;


    @GetMapping("aa")
    public  String doA(){
        return "aa를 돌려줄게";
    }

}
