package day8;

public class App {
    public static void main(String[] args) {
        MayTinh<Double> mayTinh = new MayTinhDouble();
        System.out.println(mayTinh.cong(1.0, 2.0));
        System.out.println(mayTinh.tru(1.0, 2.0));

        SoPhuc z1 = new SoPhuc(3, 4);
        SoPhuc z2 = new SoPhuc(5, 6);

        MayTinh<SoPhuc> mayTinhSoPhuc = new MayTinhSoPhuc();
        System.out.println(mayTinhSoPhuc.cong(z1, z2));

        SoPhuc tich = mayTinhSoPhuc.nhan(z1, z2);
        System.out.println(tich);

        SoPhuc thuong = mayTinhSoPhuc.chia(z1, z2);
        System.out.println(thuong);

        // z = (z1 + z2) * z3 / z4 ??
    }
}
