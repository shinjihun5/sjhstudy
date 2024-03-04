package org.example;


class mobilephon{
    protected String number;

    public mobilephon(String number){
        this.number = number;
    }
    public void  answer(){
        System.out.println("대답해야하는 번호는 "+number);
    }
}

class smartphone extends mobilephon{
    private  String androidver;
    public smartphone(String number, String ver){
        super(number);
        this.androidver = ver;

    }
    public void  playapp(){
        System.out.println("앱 실행한 안드로이드 버전은 "+androidver);
    }

}
public class main3 {

    public static void main(String[] args) {
        smartphone sp = new smartphone("01033038593","1.0");
    sp.playapp();
    sp.answer();

    mobilephon mp = new smartphone("01033038593","2.0");
    mp.answer();

    }



}


