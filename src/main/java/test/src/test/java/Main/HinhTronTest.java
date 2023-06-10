package Main;

import org.junit.jupiter.api.Assertions;
import org.junit.jupiter.api.DisplayName;
import org.junit.jupiter.api.Test;

import static org.junit.jupiter.api.Assertions.*;

public class HinhTronTest {
    @Test
    @DisplayName("Test tính chu vi của hình tròn")
    public void testChuVi() {
        HinhTron ht = new HinhTron(2.234);
        double expectedChuVi = 14.03;
        double actualChuVi = ht.chuVi();
        Assertions.assertEquals(expectedChuVi, actualChuVi);
    }

    @Test
    @DisplayName("Test tính diện tích của hình tròn")
    public void testDienTich() {
        HinhTron ht = new HinhTron(2.234);
        double expectedDienTich = 15.67;
        double actualDienTich = ht.dienTich();
        Assertions.assertEquals(expectedDienTich, actualDienTich);
    }

    @Test
    @DisplayName("Test ngoại lệ với bán kính âm")
    public void testExceptionWithNegativeRadius() {
        Exception exception = Assertions.assertThrows(RuntimeException.class, () -> {
            HinhTron ht = new HinhTron(-3);
        });

        String expectedMessage = "Bán kính phải là số dương";
        String actualMessage = exception.getMessage();
        Assertions.assertEquals(expectedMessage, actualMessage);
    }

    @Test
    @DisplayName("Test ngoại lệ với bán kính bằng 0")
    public void testExceptionWithZeroRadius() {
        Exception exception = Assertions.assertThrows(RuntimeException.class, () -> {
            HinhTron ht = new HinhTron(0);
        });

        String expectedMessage = "Bán kính phải là số dương";
        String actualMessage = exception.getMessage();
        Assertions.assertEquals(expectedMessage, actualMessage);
    }
}