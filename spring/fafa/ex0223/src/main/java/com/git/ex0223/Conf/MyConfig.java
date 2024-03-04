package com.git.ex0223.Conf;

import com.git.ex0223.Component.AA;
import com.git.ex0223.Component.BB;
import org.springframework.context.annotation.Bean;
import org.springframework.context.annotation.Configuration;

@Configuration
public class MyConfig {

    @Bean
    public AA aa(){
        return new AA();
    }
    @Bean
    public BB bb(){
        return new BB();
    }

}
