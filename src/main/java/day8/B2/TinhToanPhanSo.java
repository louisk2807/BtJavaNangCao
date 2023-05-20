package day8.B2;

import day8.SoPhuc;

public class TinhToanPhanSo implements ITinhToan<PhanSo> {


    @Override
    public PhanSo cong(PhanSo t1, PhanSo t2) {
        int tuSoMoi = t1.getTuSo() * t2.getMauSo() + t2.getTuSo() * t1.getMauSo();
        int mauSoMoi = t1.getMauSo() * t2.getMauSo();
        return new PhanSo(tuSoMoi, mauSoMoi);
    }

    @Override
    public PhanSo tru(PhanSo t1, PhanSo t2) {
        int tuSoMoi = t1.getTuSo() * t2.getMauSo() - t2.getTuSo() * t1.getMauSo();
        int mauSoMoi = t1.getMauSo() * t2.getMauSo();
        return new PhanSo(tuSoMoi, mauSoMoi);
    }

    @Override
    public PhanSo nhan(PhanSo t1, PhanSo t2) {
        int tuSoMoi = t1.getTuSo() * t2.getTuSo();
        int mauSoMoi = t1.getMauSo() * t2.getMauSo();
        return new PhanSo(tuSoMoi, mauSoMoi);
    }

    @Override
    public PhanSo chia(PhanSo t1, PhanSo t2) {
        if (t2.getTuSo() == 0) {
            throw new IllegalArgumentException("Khong the chia cho phan so 0");
        }
        int tuSoMoi = t1.getTuSo() * t2.getMauSo();
        int mauSoMoi = t1.getMauSo() * t2.getTuSo();
        return new PhanSo(tuSoMoi, mauSoMoi);

    }
}
