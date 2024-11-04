import java.util.Queue;

public class Customer extends Thread {
    private final int customerId;
    private final Queue<Integer> orderQueue;

    public Customer(int customerId, Queue<Integer> orderQueue) {
        this.customerId = customerId;
        this.orderQueue = orderQueue;
    }

    @Override
    public void run() {
        try {
            // Simulate placing an order
            int orderNumber = (int) (Math.random() * 100);
            orderQueue.add(orderNumber);
            System.out.println("Customer " + customerId + " placed an order.");
        } catch (Exception e) {
            System.out.println("Error in Customer " + customerId);
        }
    }
}
