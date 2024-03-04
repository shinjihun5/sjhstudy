package com.git.ex0226.member;

import org.springframework.stereotype.Controller;
import org.springframework.web.bind.annotation.GetMapping;

@Controller

public class MemberController {

    @GetMapping("aa")
    public String aa(){
        return "aa";
    }
}
