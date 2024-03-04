package org.example;

import java.util.ArrayList;
import java.util.List;

class AA{
    @Override
    public String toString() {
        return "AA{}";
    }
}

class BB extends AA{
    @Override
    public String toString() {
        return "BB{}";
    }
}

class CC extends AA{
    @Override
    public String toString() {
        return "CC{}";
    }
}

public class main5 {


    public static void main(String[] args) {
        List<AA> list = new ArrayList<>();


    }
}
