//client code

public class Main{
    public static void main(String args[]){
        DocumentFactory factory; //reference variable of abstract class

        factory = new WordFactory();
        Document word = factory.createDocument();   //client uses the factory to get objects, it does not need to depend on concrete classes
        word.open();

        factory = new PdfFactory();
        Document pdf = factory.createDocument();
        pdf.open();

        factory = new ExcelFactory();
        Document excel = factory.createDocument();
        excel.open();
    }
}
