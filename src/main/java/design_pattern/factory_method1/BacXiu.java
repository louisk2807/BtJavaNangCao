package design_pattern.factory_method1;

public class BacXiu implements Cafe{
    private String loaiCafe;
    private int nhietDo;

    public BacXiu(String loaiCafe, int nhietDo) {
        this.loaiCafe = loaiCafe;
        this.nhietDo = nhietDo;
    }

    @Override
    public void taoCaPhe() {
        System.out.println("Đang pha cà phê Bạc xỉu...");
        System.out.println("Loại cà phê: " + loaiCafe);
        System.out.println("Nhiệt độ nước: " + nhietDo + " độ C");
    }
}
