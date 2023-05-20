package day8;

public class MayTinhSoPhuc implements MayTinh<SoPhuc>{
    @Override
    public SoPhuc cong(SoPhuc t1, SoPhuc t2) {
        SoPhuc tong = new SoPhuc();
        tong.setA(t1.getA() + t2.getA());
        tong.setB(t1.getB() + t2.getB());
        return tong;
    }

    @Override
    public SoPhuc tru(SoPhuc t1, SoPhuc t2) {
        SoPhuc hieu = new SoPhuc();
        hieu.setA(t1.getA() - t2.getA());
        hieu.setB(t1.getB() - t2.getB());
        return hieu;
    }

    @Override
    public SoPhuc nhan(SoPhuc t1, SoPhuc t2) {
        SoPhuc tich = new SoPhuc();
        // Phan thuc cua so phuc tich
        double phanThuc = t1.getA() * t2.getA() - t1.getB()*t2.getB();
        double phanAo = t1.getA() * t2.getB() + t2.getA() * t1.getB();

        tich.setA(phanThuc);
        tich.setB(phanAo);

        return tich;
    }

    @Override
    public SoPhuc chia(SoPhuc t1, SoPhuc t2) {
        SoPhuc tmp = new SoPhuc(t2.getA(), -t2.getB());
        SoPhuc thuong = nhan(t1, tmp);
        thuong.setA(thuong.getA() / (t2.getA() * t2.getA() + t2.getB() * t2.getB()));
        thuong.setB(thuong.getB() / (t2.getA() * t2.getA() + t2.getB() * t2.getB()));
        return thuong;
    }
}
