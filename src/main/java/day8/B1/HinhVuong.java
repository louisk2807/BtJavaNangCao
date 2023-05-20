package day8.B1;

public class HinhVuong implements IHinhHoc{
    private double canh;

    public HinhVuong(double canh) {
        this.canh = canh;
    }
    @Override
    public double tinhChuVi() {
        return canh * 4;
    }

    @Override
    public double tinhDienTich() {
        return canh * canh;
    }
}
