public class Logger{

    //static variable to hold the one and only instance
    private static Logger uniqueLogger;   //only one instance will be created belonging to the class
    private Logger(){
        System.out.println("This is a Logger instance");
    }
    public static Logger getInstance(){ //global access point for the single instance (will be shared by all objects)
        if(uniqueLogger == null){
            uniqueLogger = new Logger(); //if no object exists, one will be created on the heap
        }
        return uniqueLogger; //returns the instance
    }
    public void show(String message){
        System.out.println("Log:" + message);
    }
}
