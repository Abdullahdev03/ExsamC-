class Circle
{
  double radius;
  double pi;
  public double Radius { get{ return radius;} set{radius = value;} } 
  public double PI { get{ return pi;} set{pi = value;} } 

  public double GetArea() { 
    double d;
    d = Radius*Radius * PI;
    return d;
  }
  public double GetRadius() {
    return Radius;

  }
  public double GetDiametr(){
    return Radius*2 ;
  }
  public double GetCircumference()
  {
    double a;
    a = 2* PI *Radius;
    return a;
  }
}