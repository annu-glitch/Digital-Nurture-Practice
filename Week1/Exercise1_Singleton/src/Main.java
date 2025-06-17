public class Main {
    public static void main(String[] args) {
        // Try to get logger instance
        Logger logger1 = Logger.getInstance();
        logger1.show("This is the first log message.");

        // Try to get logger instance again
        Logger logger2 = Logger.getInstance();
        logger2.show("This is the second log message.");

        // Check if both references point to the same object
        if (logger1 == logger2) {
            System.out.println("Same logger instance (Singleton works).");
        } else {
            System.out.println("Different instances (Singleton failed).");
        }
    }
}
