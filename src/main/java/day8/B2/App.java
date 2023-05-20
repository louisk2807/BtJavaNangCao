package day8.B2;

import day8.MayTinh;
import day8.MayTinhSoPhuc;
import day8.SoPhuc;

public class App {
    public static void main(String[] args) {
        TinhToanSoThuc tinhToanSoThuc = new TinhToanSoThuc();


        // Tính toán số thực
        double cong = tinhToanSoThuc.cong(2.5, 3.7);
        double tru = tinhToanSoThuc.tru(5.6, 2.1);
        double nhan = tinhToanSoThuc.nhan(4.2, 1.5);
        double chia = tinhToanSoThuc.chia(10.0, 2.5);

        System.out.println("Tổng: " + cong);
        System.out.println("Hiệu: " + tru);
        System.out.println("Tích: " + nhan);
        System.out.println("Thương: " + chia);

        // Tính toán phân số
        PhanSo ps1 = new PhanSo(1, 2);
        PhanSo ps2 = new PhanSo(3, 4);

        ITinhToan<PhanSo> t = new TinhToanPhanSo();
        System.out.println("Tong phan so: "+ t.cong(ps1, ps2));
        PhanSo hieu = t.nhan(ps1, ps2);
        System.out.println("Hieu phan so: "+hieu);
        PhanSo tich = t.nhan(ps1, ps2);
        System.out.println("Tich phan so: "+tich);

        PhanSo thuong = t.chia(ps1, ps2);
        System.out.println("Thuong phan so: "+thuong);
    }
}
