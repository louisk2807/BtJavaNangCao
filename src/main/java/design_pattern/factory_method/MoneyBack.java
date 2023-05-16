package design_pattern.factory_method;

public class MoneyBack implements Card{
    @Override
    public String getCardType() {
        return "MoneyBack";
    }

    @Override
    public int getCreditLimit() {
        return 50000;
    }

    @Override
    public int getAnnualCharge() {
        return 0;
    }
}
