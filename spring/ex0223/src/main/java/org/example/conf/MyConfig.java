package org.example.conf;

import Component.AA;
import Component.BB;
import org.springframework.context.annotation.Bean;
import org.springframework.context.annotation.Configuration;

@Configuration
public class MyConfig {

public AA aa(){
    return new AA();
}
    @Bean
    public BB bb(){
    return new BB();
    }
}
