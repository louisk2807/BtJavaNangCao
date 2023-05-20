package day8.B2;

import day8.SoPhuc;

public class TinhToanPhanSo implements ITinhToan<PhanSo> {

    @Override
    public PhanSo cong(PhanSo t1, PhanSo t2) {
        return t1.cong(t2);
    }

    @Override
    public PhanSo tru(PhanSo t1, PhanSo t2) {
        return null;
    }

    @Override
    public PhanSo nhan(PhanSo t1, PhanSo t2) {
        return null;
    }

    @Override
    public PhanSo chia(PhanSo t1, PhanSo t2) {
        return null;
    }
}
