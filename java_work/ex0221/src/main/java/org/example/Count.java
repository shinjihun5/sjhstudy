package org.example;

public class Count {
    private  int cnt;
     public void incre() {
         synchronized (this) {
             cnt++;
         }
     }
    synchronized public void decre(){
        cnt--;
    }

    public int getCnt() {
        return cnt;
    }
}
