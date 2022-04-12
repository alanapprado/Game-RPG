Hero Arus;

   namespace dotnet___poo
{
   class Program
   {
       
    static void Main(string[] args)
    {
       Hero Arus = new Hero("Arus", 23, "Knight");
       Hero wizard = new Hero("Jenicca", 23, "White Wizard");


     Console.WhiteLine(Arus.Attack());
     Console.WhiteLine(Wizard.Attack());
    }
    public virtual string Attack(){
    return this.Name + " Atacou com a sua espada";
    }

