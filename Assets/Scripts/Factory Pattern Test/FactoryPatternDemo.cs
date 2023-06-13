using System.Collections;
using System.Collections.Generic;

public class FactoryPatternDemo
{
    
    private void Start()
    {
    ShapeFactory shapeFactory = new ShapeFactory();
    
      //get an object of Circle and call its draw method.
    Shape shape1 = shapeFactory.getShape("CIRCLE");

      //get an object of Rectangle and call its draw method.
    Shape shape2 = shapeFactory.getShape("RECTANGLE");

      //get an object of Square and call its draw method.
    Shape shape3 = shapeFactory.getShape("SQUARE");

   }
}
