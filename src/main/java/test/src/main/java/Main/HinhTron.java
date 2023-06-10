package Main;

public class HinhTron {
    private double banKinh = 1.0;

    public HinhTron() {
    }

    public HinhTron(double banKinh) {
        if(banKinh <= 0 || banKinh <= 0){
            throw new RuntimeException("Bán kính phải là số dương");
        }
        this.banKinh = banKinh;
    }

    // Setter-Getter
    public double getBanKinh() {
        return banKinh;
    }

    public void setBanKinh(double banKinh) {
        if(banKinh <= 0){
            throw new RuntimeException("Bán kính phải là số dương");
        }
        this.banKinh = banKinh;
    }

    public double chuVi() {

        double cv = banKinh * 2 * 3.14;
        return Math.round(cv * 100) / 100.0;
    }

    public double dienTich() {

        double dt = banKinh * banKinh * 3.14;
        return Math.round(dt * 100) / 100.0;
    }

    @Override
    public String toString() {
        return "HinhTron{" +
                "banKinh=" + banKinh +
                ",chuVi=" + chuVi() +
                ",dienTich=" + dienTich() +
                '}';
    }
}