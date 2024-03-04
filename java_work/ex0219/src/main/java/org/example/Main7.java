package org.example;

import java.io.BufferedReader;
import java.io.BufferedWriter;
import java.io.FileReader;
import java.io.FileWriter;

public class Main7 {

    public static void main(String[] args) {
        try(BufferedWriter bw = new BufferedWriter(new FileWriter("ccc.txt"))) {
         bw.write("a");
         bw.write("b");
         bw.newLine();
         bw.write("c");
        }catch (Exception e){
            e.printStackTrace();
        }
        try(BufferedReader br = new BufferedReader(new FileReader("ccc.txt"))) {
            while (true) {
                String txt = br.readLine();
                if (txt ==null)
                    break;
                System.out.println(txt);
            }
        }catch (Exception e) {
            e.printStackTrace();
        }
        }
}
