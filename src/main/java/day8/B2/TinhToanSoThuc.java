package day8.B2;

public class TinhToanSoThuc implements ITinhToan<Double> {


    @Override
    public Double cong(Double t1, Double t2) {
        return t1 + t2;
    }

    @Override
    public Double tru(Double t1, Double t2) {
        return t1 - t2;

    }

    @Override
    public Double nhan(Double t1, Double t2) {
        return t1 * t2;
    }

    @Override
    public Double chia(Double t1, Double t2) {
        if(t2 == 0){
            throw new RuntimeException("Khong the chia cho 0");
        }
        return t1/ t2;
    }
}
