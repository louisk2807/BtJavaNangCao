package design_pattern.adapter;

public class Client {
    public static void main(String[] args) {
        VietnameseTarget client = new TranslatorAdapter(new EnglishAdaptee());
        client.send("Xin chào");

    }
}
    