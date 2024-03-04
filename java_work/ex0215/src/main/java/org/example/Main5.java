package org.example;

class bank{
     int a = 0;
    public  int dlqrma(int n){
        a += n;
        return a;
    }
    public  int cnfrma(int n){
        a -= n;
        return a;
    }
    public static void dPrmawhhgl(int n){
        System.out.println(a);
        return a;
    }
}



public class Main5 {

    public static void main(String[] args) {

        bank Bank1 = new bank();
        Bank1.dlqrma(5000);
        Bank1.dPrmawhhgl(Bank1.a);
        Bank1.cnfrma(2000);
        Bank1.dPrmawhhgl(Bank1.a);
        /*

        Main5 bank1 = bank2;
        bank1.dlqrma(5000);
        bank2.dlqrma(10000);
        bank1.dPrmawhhgl(bank1.a);
        bank2.dPrmawhhgl(bank2.a);
        bank1.cnfrma(1500);
        bank2.cnfrma(5800);
        bank1.dPrmawhhgl(bank1.a);
        bank2.dPrmawhhgl(bank2.a);
*/
    }
    }
