package design_pattern.factory_method1;

public class CafeFactory {
    public static Cafe taoCafe(int luaChon, String loaiCafe) {
        switch (luaChon) {
            case 1:
                return new Espresso(loaiCafe, 5);
            case 2:
                return new DenDa(loaiCafe, 90);
            case 3:
                return new NauDa(loaiCafe, 85);
            case 4:
                return new Latte(loaiCafe, 70);
            case 5:
                return new BacXiu(loaiCafe, 70);
            default:
                return null;
        }
    }
}

