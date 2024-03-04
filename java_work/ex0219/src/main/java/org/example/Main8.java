package org.example;

import java.io.*;

class SBox implements Serializable {
    private String name;
    private int age;

    @Override
    public String toString() {
        return "SBox{" +
                "name='" + name + '\'' +
                ", age=" + age +
                '}';
    }

    public SBox(String name, int age) {
        this.name = name;
        this.age = age;
    }
}

public class Main8 {
    public static void main(String[] args) {
        SBox sbox1 = new SBox("감자",28);
        SBox sbox2 = new SBox("고구마",20);

        try (ObjectOutputStream oos = new ObjectOutputStream(new FileOutputStream("obj.bin"))){
           oos.writeObject(sbox1);
           oos.writeObject(sbox2);

        }catch (Exception e){
        }
        try (ObjectInputStream ois = new ObjectInputStream(new FileInputStream("obj.bin"))){
            SBox obj1 = (SBox) ois.readObject();
            System.out.println();
            SBox obj2 = (SBox) ois.readObject();
            System.out.println();
        }catch (Exception e){
        }

    }
}

