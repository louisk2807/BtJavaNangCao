package oop.b7_1;

import java.util.Date;

public class Visit {
    private Customer customer;
    private Date date;
    private double serviceExpense;
    private double productExpense;

    public Visit(Customer customer, Date date) {
        this.customer = customer;
        this.date = date;
    }

    public Customer getCustomer() {
        return customer;
    }


    public double getServiceExpense() {
        return serviceExpense;
    }

    public void setServiceExpense(double serviceExpense) {
        this.serviceExpense = serviceExpense;
    }

    public double getProductExpense() {
        return productExpense;
    }

    public void setProductExpense(double productExpense) {
        this.productExpense = productExpense;
    }

    public double getTotalExpense() {
        double serviceDiscountRate = DiscountRate.getServiceDiscountRate(customer);
        double productDiscountRate = DiscountRate.getProductDiscountRate();
        double totalServiceExpense = serviceExpense * (1 - serviceDiscountRate);
        double totalProductExpense = productExpense * (1 - productDiscountRate);
        return totalServiceExpense + totalProductExpense;
    }
}
