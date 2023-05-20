package day8.B1;

public class Drawable {
    public void draw(IHinhHoc hinhHoc) {
        System.out.println("Vẽ ra " + hinhHoc.getClass().getSimpleName() + ":");
        System.out.println("Diện tích: " + hinhHoc.tinhDienTich());
        System.out.println("Chu vi: " + hinhHoc.tinhChuVi());
    }
}
