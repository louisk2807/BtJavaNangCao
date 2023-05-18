package design_pattern.adapter;

public class TranslatorAdapter implements VietnameseTarget{

    private EnglishAdaptee adaptee;

    public TranslatorAdapter(EnglishAdaptee adaptee) {
        this.adaptee = adaptee;
    }

    @Override
    public void send(String words) {

        System.out.println(words);
        String vietnameseWords = this.translate(words);

        adaptee.receive(vietnameseWords);
    }

    private String translate(String vietnameseWords) {
        System.out.println("Translated!");
        return "Hello";

    }
}
