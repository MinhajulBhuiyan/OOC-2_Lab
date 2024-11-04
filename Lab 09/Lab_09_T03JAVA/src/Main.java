public class Main {
    public static void main(String[] args) {
        Circle circle = new Circle();
        Rectangle rectangle = new Rectangle();
        Triangle triangle = new Triangle();
        Cube cube = new Cube();
        Cylinder cylinder = new Cylinder();


        //Node<Shape> node0 = new Node<TwoDShape>(circle);
        Node<TwoDShape> node1 = new Node<>(circle);
        Node<TwoDShape> node2 = new Node<>(rectangle);
        Node<TwoDShape> node3 = new Node<>(triangle);
        Node<ThreeDShape> node4 = new Node<>(cube);
        Node<ThreeDShape> node5 = new Node<>(cylinder);
    }

}
