package com.example.chap06.member;

import org.springframework.stereotype.Controller;
import org.springframework.web.bind.annotation.GetMapping;
import org.springframework.web.bind.annotation.RequestMapping;


import java.util.Arrays;
import java.util.List;

@Controller
@RequestMapping("member")
public class MemberController {

    @GetMapping("list")
    public String list(){
      //  List<Member> list = Arrays.asList(new Member(), new Member());
        return "list";

    }
}
