using System;

class Car
{

    //Attribute declaration
    private int idNumber;
    private string make;
    private string model;
    private string color;
    private double value;

    //Method declaration
    public int getIdNumber()
    {
        return idNumber;
    }

    public void setIdNumber(int id)
    {
        idNumber = id;
    }

    public string getMake()
    {
        return make;
    }

    public void setMake(string new_make)
    { 
        make = new_make;
    }

    public string getColor()
    { 
        return color;
    }

    public void setColor(string new_color)
    { 
        color = new_color;
    }

    public string getModel()
    { 
        return model;
    }

    public void setModel(string new_model)
    { 
        model = new_model;
    }

    public double getValue()
    { 
        return value;
    }

    public void setValue(double new_value)
    { 
        value = new_value;
    }

    //Constructor Defaults
    public Car()
    {
        idNumber = 0;
        make = "Car";
        model = "Sedan";
        color = "White";
        value = 1000;
    }

    //Constructor with Parameters
    public Car(int car_number, string car_make, string car_model, string car_color, double car_value)
    {
        idNumber = car_number;
        make = car_make;
        model = car_model;
        color = car_color;
        value = car_value;
    }
}