package design_pattern.factory_method1;

import java.util.Scanner;

public class Client {
    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);
        CafeFactory cafeFactory = new CafeFactory();

        int luaChon;
        String loaiCafe;

        do {
            // Hiển thị menu
            System.out.println("--- MÁY PHA CÀ PHÊ ---");
            System.out.println("1. Espresso");
            System.out.println("2. Đen đá");
            System.out.println("3. Nâu đá");
            System.out.println("4. Latte");
            System.out.println("5. Bạc xỉu");
            System.out.println("0. Thoát");
            System.out.print("Nhập lựa chọn của bạn: ");
            luaChon = scanner.nextInt();

            if (luaChon == 0) {
                System.out.println("Kết thúc chương trình.");
                break;
            }

            scanner.nextLine(); // Đọc bỏ ký tự newline

            System.out.print("Nhập loại cà phê: ");
            loaiCafe = scanner.nextLine();

            Cafe cafe = cafeFactory.taoCafe(luaChon, loaiCafe);
            if (cafe != null) {
                cafe.taoCaPhe();
                System.out.println("Cà phê đã được pha xong.");
            } else {
                System.out.println("Lựa chọn không hợp lệ.");
            }

            System.out.println();
        } while (true);

        scanner.close();
    }
}
