import java.util.Queue;

public class Receptionist {
    private final Queue<Integer> orderQueue;

    public Receptionist(Queue<Integer> orderQueue) {
        this.orderQueue = orderQueue;
    }

    public void assignTable(int tableNumber, int customerId) {
        System.out.println("Receptionist assigned Table " + tableNumber + " to Customer " + customerId);
    }
}
