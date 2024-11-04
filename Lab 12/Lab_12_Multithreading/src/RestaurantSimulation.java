import java.util.LinkedList;
import java.util.Queue;

public class RestaurantSimulation {
    public static void main(String[] args) {
        Queue<Integer> orderQueue = new LinkedList<>();
        Queue<String> cookedFoodQueue = new LinkedList<>();

        Receptionist receptionist = new Receptionist(orderQueue);
        Chef chef1 = new Chef(orderQueue, cookedFoodQueue);
        Chef chef2 = new Chef(orderQueue, cookedFoodQueue);
        Waiter waiter1 = new Waiter(cookedFoodQueue);
        Waiter waiter2 = new Waiter(cookedFoodQueue);

        receptionist.assignTable(1, 1);
        receptionist.assignTable(2, 2);

        chef1.start();
        chef2.start();
        waiter1.start();
        waiter2.start();

        int numCustomers = 5;

        for (int i = 1; i <= numCustomers; i++) {
            new Customer(i, orderQueue).start();
        }
    }
}
