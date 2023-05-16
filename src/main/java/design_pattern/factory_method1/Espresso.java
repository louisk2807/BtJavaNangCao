package design_pattern.factory_method1;

public class Espresso implements Cafe {
    private String loaiCafe;
    private int apSuat;

    public Espresso(String loaiCafe, int apSuat) {
        this.loaiCafe = loaiCafe;
        this.apSuat = apSuat;
    }
    @Override
    public void taoCaPhe() {
        System.out.println("Đang pha cà phê Espresso...");
        System.out.println("Loại cà phê: " + loaiCafe);
        System.out.println("Áp suất: " + apSuat + " Pa");
    }
}
