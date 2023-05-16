package design_pattern.factory_method;

public class CardFactory {
    private  CardFactory(){};
    public static Card getCard(String card) {
        switch (card) {
            case "MoneyBack":
                return new MoneyBack();
            case "Platinum":
                return new Platinum();
            case "Titanium":
                return new Titanium();
            default:
                return null;
        }
    }
}
