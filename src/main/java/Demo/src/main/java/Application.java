
import data.BookData;
import data.CSVBookData;
import data.FactoryBookData;
import data.TypeBookData;
import model.Book;

import java.util.List;
import java.util.Scanner;

public class Application {
    private static void menu(){
        System.out.println("--- BOOK MANAGER --- -");
        System.out.println("1. Danh sách các cuốn sách");
        System.out.println("2. Tìm kiếm sách theo tác giả, ISBN hoặc tiêu đề ");
        System.out.println("3. Sắp xếp theo điểm rating tăng dần");
        System.out.println("4. Lấy ra 10 cuốn sách có rating cao nhất");
        System.out.println("0. Thoát ");
    }
    public static void main(String[] args) {
        BookData bookData = FactoryBookData.getBookData(TypeBookData.CSV);
        //lay danh sach
        List<Book> books = bookData.getAllBook();
        Scanner in = new Scanner(System.in);
        int choice = -1;
        do{
            menu();
            choice = Integer.parseInt(in.nextLine());
            switch (choice){
                case 1:
                    System.out.println("Danh sách các cuốn sách:");
                    for(int i = 0; i < books.size(); i++);
                    System.out.printf("[STT = %d, ISBN = %s, TITLE = %s]", i + 1 ,books.get(i).getIsbn(), books.get(i).getTitle() );
            }
        }
        while (choice == 0);


    }
}
