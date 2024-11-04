import java.util.Queue;

public class Waiter extends Thread {
    private final Queue<String> cookedFoodQueue;

    public Waiter(Queue<String> cookedFoodQueue) {
        this.cookedFoodQueue = cookedFoodQueue;
    }

    @Override
    public void run() {
        while (true) {
            // Serve a dish from the cooked food queue
            String dishToServe = cookedFoodQueue.poll();
            if (dishToServe != null) {
                System.out.println("Waiter " + Thread.currentThread().getId() + " is serving " + dishToServe + " to a customer");
            }
        }
    }
}
