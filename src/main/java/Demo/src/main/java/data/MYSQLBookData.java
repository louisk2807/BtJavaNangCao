package data;

import model.Book;

import java.util.List;

public class MYSQLBookData implements BookData{
    public MYSQLBookData (){
        throw new RuntimeException("MYSQL chưa hỗ trợ!");
    }
    @Override
    public List<Book> getAllBook() {
        return null;
    }
}
