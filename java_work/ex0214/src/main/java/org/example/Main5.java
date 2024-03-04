package org.example;
class Friend{
    String name;
    Company com;
    public String getName() {
        return name;
    }
    public Company getCom() {
        return com;
        }
    public Friend(String name, Company com) {
        this.name = name;
        this.com = com;
    }
}
class Company{
    String cName;
    ContInfo contInfo;
    public Company(String cName, ContInfo contInfo) {
        this.cName = cName;
        this.contInfo = contInfo;
    }
    public String getcName() {
        return cName;
    }
    public ContInfo getContInfo() {
        return contInfo;
    }
}
class ContInfo{
    public String getPhone() {
        return phone;
    }
    public String getAddr() {
        return addr;
    }
    String addr;
    String phone;
    public ContInfo(String addr,String phone) {
        this.addr = addr;
    }

    public ContInfo(String phone) {
        this.phone = phone;
    }
}
public class Main5 {
    public static void main(String[] args) {

        Friend friend = new Friend("홍길동",new Company("AA",null));

      //  Company com = Friend.getCom();
        //ContInfo contInfo = com.getContInfo();
       // String addr = contInfo.getAddr();

        //System.out.println("adrr = "+addr);

    }

}
