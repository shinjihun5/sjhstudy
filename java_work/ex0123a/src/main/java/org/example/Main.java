package org.example;


class supercls{
    public int a = 10;
    public void doA(){
        System.out.println("supercls doA");
    }

}
class subcls extends supercls{

    public int a = 20;
    @Override

    public void doA() {
        System.out.println("subcls doA");
    }
}
public class Main {
    public static void main(String[] args) {
        supercls sc = new supercls();
        sc.doA();
        subcls sa = new subcls();
        sa.doA();
    }


}
