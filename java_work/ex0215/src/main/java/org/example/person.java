package org.example;

// age가 20살인 것만 필터링
class person {
    private String name;
    private int age;
    public int getAge(){
        return age;
    }

    public String getName() {
        return name;
    }

    public person(String name, int age) {
        this.name = name;
        this.age = age;
    }

    @Override
    public String toString() {
        return "person{" +
                "name='" + name + '\'' +
                ", age=" + age +
                '}';
    }
}
