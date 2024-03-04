package aa;

public class main3 {
    public static void main(String[] args) {
        print prn = new print();
        prn.print();

        printable printable = new printable() {
            @Override

            public void print() {
                System.out.println("인터페이스");
            }

        };
        printable.print();
        printable lamda1 = ()->{
            System.out.println("람다");
        };
        lamda1.print();
    }
}


