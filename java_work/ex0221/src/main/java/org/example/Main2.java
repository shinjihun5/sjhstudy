package org.example;

public class Main2 extends Thread {
    private String name;

    public Main2(String name) {
        this.name = name;
    }

    @Override
    public void run() {
        for (int i = 0; i < 100; i++) {
            if (name.equals("athread")) {
                System.out.println("athread = "+i);
            }
                else {
                System.out.println("a" + i);
            }
        }
    }

    public static void main(String[] args) {
        Main2 t1 = new Main2("athread");
        t1.start();
        Main2 t2 = new Main2("fafaa");
        t2.start();
    }

}
