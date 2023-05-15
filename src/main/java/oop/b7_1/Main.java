package oop.b7_1;

import java.text.SimpleDateFormat;
import java.util.Date;

public class Main {
    public static void main(String[] args) {
        Customer customer = new Customer("John", true, Membership.PREMIUM);
        Date visitDate = new Date(); // Current date/time
        SimpleDateFormat dateFormat = new SimpleDateFormat("dd/MM/yyyy");
        Date currentDate = new Date();
        Visit visit1 = new Visit(customer, currentDate);
        visit1.setServiceExpense(100);
        visit1.setProductExpense(50);
        System.out.println("Total expense for " + visit1.getCustomer() + " on " + dateFormat.format(currentDate) + ": $" + visit1.getTotalExpense());
    }
}
