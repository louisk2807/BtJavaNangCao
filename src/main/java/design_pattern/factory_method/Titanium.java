package design_pattern.factory_method;

public class Titanium implements Card{
    @Override
    public String getCardType() {
        return "Titanium";
    }

    @Override
    public int getCreditLimit() {
        return 200000;
    }

    @Override
    public int getAnnualCharge() {
        return 1000;
    }
}
