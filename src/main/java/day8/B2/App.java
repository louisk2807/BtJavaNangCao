package day8.B2;

import day8.SoPhuc;

public class App {
    public static void main(String[] args) {
        TinhToanSoThuc tinhToanSoThuc = new TinhToanSoThuc();
        TinhToanPhanSo tinhToanPhanSo = new TinhToanPhanSo();

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
        SoPhuc ps1 = new PhanSo(3, 4);
        PhanSo ps2 = new PhanSo(1, 2);
        PhanSo ps3 = new PhanSo(2, 3);

        PhanSo tongPhanSo = tinhToanPhanSo.cong(ps1, ps2);
        PhanSo hieuPhanSo = tinhToanPhanSo.tru(ps1, ps2);
        PhanSo nhanPhanSo = tinhToanPhanSo.nhan(ps1, ps2);
        PhanSo chiaPhanSo = tinhToanPhanSo.chia(ps1, ps2);

        System.out.println("Tổng phân số: " + tongPhanSo);
        System.out.println("Hiệu phân số: " + hieuPhanSo);
        System.out.println("Tích phân số: " + nhanPhanSo);
        System.out.println("Thương phân số: " + chiaPhanSo);
    }
}
