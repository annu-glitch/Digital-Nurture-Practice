class PdfFactory extends DocumentFactory{    //concrete creator 2
    public Document createDocument(){
        return new PdfDocument();
    }
}
