package design_pattern.factory_method1;

public class Latte implements Cafe {
    private String loaiCafe;
    private int nhietDo;

    public Latte(String loaiCafe, int nhietDo) {
        this.loaiCafe = loaiCafe;
        this.nhietDo = nhietDo;
    }

    public void taoCaPhe() {
        System.out.println("Đang pha cà phê Latte...");
        System.out.println("Loại cà phê: " + loaiCafe);
        System.out.println("Nhiệt độ nước: " + nhietDo + " độ C");
        // Pha cà phê Latte
    }
}
