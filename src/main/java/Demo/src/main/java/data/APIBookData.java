package data;

import model.Book;

import java.util.List;

public class APIBookData implements BookData{
    public APIBookData (){
        throw new RuntimeException("API chưa hỗ trợ!");
    }
    @Override
    public List<Book> getAllBook() {
        return null;
    }
}
