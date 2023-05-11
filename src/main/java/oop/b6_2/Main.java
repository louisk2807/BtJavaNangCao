package oop.b6_2;

import java.util.ArrayList;

public class Main {
    public static void main(String[] args) {
        ArrayList<GeometricObject> hinh = new ArrayList<>();
        // Mang nay co the chua 1 hinh bat ki,mien la implement tu IHinhHoc3D
        Circle ht = new Circle(4);
        Rectangle hcn = new Rectangle(5,6);
        hinh.add(ht);
        hinh.add(hcn);
        for (GeometricObject h : hinh) {
            System.out.println(h);
        }


        // In ra thong tin -> the tich tung hinh


    }
}
