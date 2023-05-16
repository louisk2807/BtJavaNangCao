package design_pattern.factory_method;

public class Platinum implements Card{
    @Override
    public String getCardType() {
        return "Platinum";
    }

    @Override
    public int getCreditLimit() {
        return 100000;
    }

    @Override
    public int getAnnualCharge() {
        return 500;
    }
}
