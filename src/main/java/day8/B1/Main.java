package day8.B1;

public class Main {
    public static void main(String[] args) {
        HinhVuong hinhVuong = new HinhVuong(5);
        HinhTron hinhTron = new HinhTron(3.5);

        Drawable drawable = new Drawable();
        drawable.draw(hinhVuong);
        drawable.draw(hinhTron);
    }
}
