package org.example;

class cake {
    public void yummy() {
        System.out.println("cake yummy");
    }
}

class Acake extends cake {
    @Override
    public void yummy() {

        System.out.println("Acake yummy");
    }
}
class Bcake extends cake{
    @Override
    public void yummy()
    { super.yummy();
        System.out.println("Bcake yummy");
        }
}

public class main4 {

    public static void main(String[] args) {
        cake cb = new Bcake();
        cake ca = new Acake();
        cb.yummy();
        ca.yummy();

        System.out.println("==========");
        System.out.println(cb instanceof Bcake);
        System.out.println(cb instanceof Acake);
        System.out.println("==========");

        System.out.println("==========");
        System.out.println(ca instanceof Bcake);
        System.out.println(ca instanceof Acake);
        System.out.println("==========");


    }



    }


