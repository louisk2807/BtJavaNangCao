package oop.b7_1;

public class DiscountRate {
    public static final double PREMIUM_SERVICE_DISCOUNT = 0.2;
    public static final double GOLD_SERVICE_DISCOUNT = 0.15;
    public static final double SILVER_SERVICE_DISCOUNT = 0.1;
    public static final double PRODUCT_DISCOUNT = 0.1;

    public static double getServiceDiscountRate(Customer customer) {
        if (customer.isMember()) {
            Membership memberType = Membership.valueOf(customer.getMemberType());
            if (memberType == Membership.PREMIUM) {
                return PREMIUM_SERVICE_DISCOUNT;
            } else if (memberType == Membership.GOLD) {
                return GOLD_SERVICE_DISCOUNT;
            } else if (memberType == Membership.SILVER) {
                return SILVER_SERVICE_DISCOUNT;
            }
        }
        return 0.0;
    }

    public static double getProductDiscountRate() {
        return PRODUCT_DISCOUNT;
    }
}