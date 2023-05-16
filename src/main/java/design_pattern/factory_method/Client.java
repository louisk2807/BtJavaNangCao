package design_pattern.factory_method;

public class Client {
    public static void main(String[] args) {
        // TPBank
        Card card = CardFactory.getCard("Titanium");
        if(card != null) {
            System.out.println(card.getCardType());
            System.out.println("Hạn mức tín dụng của thẻ là "+card.getCreditLimit());
            System.out.println("Phí gia hạn của thẻ là "+card.getAnnualCharge());


        }
    }
}
