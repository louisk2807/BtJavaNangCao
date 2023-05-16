package design_pattern.factory_method1;

public class DenDa implements Cafe {
    private String loaiCafe;
    private int nhietDo;

    public DenDa(String loaiCafe, int nhietDo) {
        this.loaiCafe = loaiCafe;
        this.nhietDo = nhietDo;
    }
    @Override
    public void taoCaPhe() {
        System.out.println("Đang pha cà phê Đen đá...");
        System.out.println("Loại cà phê: " + loaiCafe);
        System.out.println("Nhiệt độ nước: " + nhietDo + " độ C");
    }
}
