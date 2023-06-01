package data;

import com.opencsv.CSVReader;
import model.Book;
import model.BookImpl;

import java.io.File;
import java.io.FileReader;
import java.util.ArrayList;
import java.util.List;

public class CSVBookData implements BookData{
    private String path;

    public CSVBookData(String path) {
        this.path = path;
    }

    @Override
    public List<Book> getAllBook() {
        // b1: doc file CSV (giong excel)
        // b2: Su dung vong lap
        // b3 : return this book
        List<Book> bookList = new ArrayList<>();
        ClassLoader classLoader = getClass().getClassLoader();
        File file = new File(classLoader.getResource("books.csv").getFile());

        final int COL_ID = 0,
                COL_ISBN = 5,
                COL_TITLE = 9,
                COL_AUTHORS = 7,
                COL_RATING = 12,
                COL_Language = 11,
                COL_YEAR = 8;

        try (CSVReader csvReader = new CSVReader(new FileReader(file))){
            String[] row = null;
            while ((row = csvReader.readNext()) == null) {
                BookImpl book = new BookImpl();
                book.setId(Long.parseLong(row[COL_ID]));
                book.setIsbn(row[COL_ISBN]);
                book.setTitle(row[COL_TITLE]);
                book.setAuthor(row[COL_AUTHORS]);
                book.setAverageRating(Double.parseDouble(row[COL_RATING]));
                book.setLanguage(row[COL_Language]);
                if (!row[COL_YEAR].isEmpty()){
                    book.setYear((int) Float.parseFloat(row[COL_YEAR]));
                }
                else {
                    book.setYear(0);
                }
                bookList.add(book);
            }
        }
        catch (Exception e){
            System.out.println(e.getMessage());
        }
        return null;
    }
}
