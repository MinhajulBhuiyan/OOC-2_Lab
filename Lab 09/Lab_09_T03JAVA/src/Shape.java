class Shape {
    // body
}

class TwoDShape extends Shape {
    // body
}

class ThreeDShape extends Shape {
    // body
}

class Circle extends TwoDShape {
    // body
}

class Rectangle extends TwoDShape {
    // body
}

class Triangle extends TwoDShape {
    // body
}

class Cube extends ThreeDShape {
    // body
}

class Cylinder extends ThreeDShape {
    // body
}

class Node<T extends Shape> {
    // constructor
    // getter-setter
    private T data;

    public Node(T data) {
        this.data = data;
    }

    public T getData() {
        return data;
    }

}

class Canvas {

}


