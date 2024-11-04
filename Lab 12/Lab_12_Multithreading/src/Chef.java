import java.util.Queue;

public class Chef extends Thread {
    private final Queue<Integer> orderQueue;
    private final Queue<String> cookedFoodQueue;

    public Chef(Queue<Integer> orderQueue, Queue<String> cookedFoodQueue) {
        this.orderQueue = orderQueue;
        this.cookedFoodQueue = cookedFoodQueue;
    }

    @Override
    public void run() {
        try {
            while (true) {
                // Simulate cooking by converting order to the dish
                Integer order = orderQueue.poll();
                if (order != null) {
                    String dish = "Dish" + order;
                    System.out.println("Chef " + Thread.currentThread().getId() + " is preparing " + dish);
                    // Simulate cooking time
                    Thread.sleep(2000);
                    cookedFoodQueue.add(dish);
                }
            }
        } catch (InterruptedException e) {
            System.out.println(Thread.currentThread().getName() + " was interrupted.");
            Thread.currentThread().interrupt(); // Restore interrupted status
        }
    }
}
