class ExcelFactory extends DocumentFactory{    //concrete creator 3
    public Document createDocument(){
        return new ExcelDocument();
    }
}
