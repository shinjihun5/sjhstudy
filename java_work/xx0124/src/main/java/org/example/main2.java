package org.example;

class  parentadder{
    public void add(int num1, int num2){
        System.out.println("합 "+(num1+num2));
    }
}
class childadder extends parentadder{

    @Override
    public void add(int num1, int num2) {
        System.out.println("덧셈을 진행합니다");
        super.add(num1, num2);

    }
}


public class main2 {
    public static void main(String[] args) {
        childadder ca = new childadder();
        ca.add(10,20);
    }

}
