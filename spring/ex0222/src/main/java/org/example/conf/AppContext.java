package org.example.conf;

import org.example.componont.AA;
import org.example.componont.BB;
import org.springframework.context.annotation.Bean;
import org.springframework.context.annotation.Configuration;

@Configuration
public class AppContext {

        @Bean
        public AA aa(){ return new AA();
        }

        @Bean
        public BB bb(){
                BB bb = new BB();
                bb.setH1(String.format("%s","안녕하세요"));
                return bb;
        }
}
