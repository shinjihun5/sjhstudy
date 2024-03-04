package org.example.mh;

import org.example.DBINFO;
import org.example.util.MyCLI;

import java.sql.Connection;
import java.sql.DriverManager;
import java.sql.PreparedStatement;
import java.sql.ResultSet;

public class MemberDB {
    private MyCLI cli = new MyCLI();

    public void insert() {
        Member member = cli.inputMember();

        boolean result = findByEmail(member.getEmail());

        if(!result) {
            try {
                // DB 연결하기
                Connection con
                        = DriverManager.getConnection(DBINFO.url, DBINFO.user, DBINFO.password);

                // SQL 구문 작성하고...
                PreparedStatement pstmt
                        = con.prepareStatement("insert into member " +
                        "(reg_time, update_time, created_by, modified_by," +
                        " address, email, name, password, role) " +
                        "values " +
                        "(now(),now(),'',''," +
                        "?,?,?,?,'user')");

                pstmt.setString(1, member.getAddr());
                pstmt.setString(2, member.getEmail());
                pstmt.setString(3, member.getName());
                pstmt.setString(4, member.getPassword());
                // SQL 구문실행하기
                pstmt.executeUpdate();
                System.out.println("입력되었습니다.");

            } catch (Exception e) {
                System.out.println("이쪽으로 온다.");
                e.printStackTrace();
            }
        }
        else{
            System.out.println("중복되어서 회원가입 실패");
        }
    }

    public boolean findByEmail(String email){
        try{
            // DB 연결하기
            Connection con
                    = DriverManager.getConnection(DBINFO.url,DBINFO.user,DBINFO.password);
            PreparedStatement pstmt =
                    con.prepareStatement("SELECT * from member where email=?");
            pstmt.setString(1, email);
            ResultSet rs = pstmt.executeQuery();

            if(rs.next()){
                return true;
            }
        }catch (Exception e){
            e.printStackTrace();
        }
        return false;
    }

    public void login() {
        Member member = cli.loginMember();
        try{
            Connection con
                    = DriverManager.getConnection(DBINFO.url,DBINFO.user,DBINFO.password);
            PreparedStatement pstmt = con.prepareStatement(
                    "SELECT * FROM member " +
                            "WHERE email=? AND PASSWORD=?");
            pstmt.setString(1, member.getEmail());
            pstmt.setString(2, member.getPassword());
            ResultSet rs = pstmt.executeQuery();



        }catch (Exception e){
            e.printStackTrace();
        }
    }
}