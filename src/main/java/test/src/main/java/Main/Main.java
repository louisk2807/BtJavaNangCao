package Main;

import java.util.Scanner;

public class Main {
    public static void main(String[] args) {
        HinhTron ht = new HinhTron(2);
        ht.setBanKinh(0);
        System.out.println("Chu vi:"+ ht.chuVi());
        System.out.println("Diện tích: "+ht.dienTich());
    }
}
