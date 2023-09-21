class Program
{



    static void Main (String[] args)
    {
        Rectangle rectangle = new Rectangle(5,4);
        Console.WriteLine("The field of the rectangle object: " + rectangle.calculateField());

        Rectangle_Struct rectangleStruct; // You can't define classes this way, but can define structures , initial values are not assigned this way
        rectangleStruct.shortEdge = 4;
        rectangleStruct.longEdge=5;    
        Console.WriteLine("The field of the rectangle object: " + rectangleStruct.calculateField());
    }

    class Rectangle //Classes are a type of referance
    {
        public int shortEdge; public int longEdge;

        public Rectangle(int shortEdge, int longEdge)
        {
            this.shortEdge = shortEdge;
            this.longEdge = longEdge;
        }

        public int calculateField()
        {
            return this.shortEdge * this.longEdge;
        }


    }

    struct Rectangle_Struct //Structs are the type of value
    {
        public int shortEdge; 
        public int longEdge; //Keeped in stack , that's way it is better in performance, up to 16 byte 

        public Rectangle_Struct(int shortEdge, int longEdge)
        {
            this.shortEdge = shortEdge;
            this.longEdge = longEdge;
        }

        public Rectangle_Struct() //Structs cannot have parameterless constructors??? But it happens here
        {
            shortEdge = 4;
            longEdge = 5;
        }
        public int calculateField()
        {
            return this.shortEdge * this.longEdge;
        }


    }
}
