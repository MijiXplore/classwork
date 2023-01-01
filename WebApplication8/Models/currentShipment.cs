using Microsoft.AspNetCore.Mvc.RazorPages;

namespace WebApplication8.Models
{
    public abstract class currentShipment
    {
        public static string? orderNum { get; set; }
        public static string? customerName { get; set;}
        public static string? orderQty { get; set;}

        
    } 

}

/*
 
1. Inheritance - To inherit properites and methods from parent class to child class
* Inherits properties and methods from parent class
* sealed - used when we don't want other classes to inherit from a class
* 
* Ex:    john obj1 = new john();
        obj1.run(); //Running
        obj1.email = "obj1@gmail.com"

2. Polymorphism: The ability of the code exists in many forms
* It occurs when we have multiple classes that are related to each by inheritance
//Case 1: One with out virtual or override
    john obj1 = new john();
    obj1.run();  //Running at 10Kms/hr...

//Case2: With virtual and override
    john obj1 = new john();
    obj1.run();  //Running at 15Kms/hr...

Why to use Inheritance and polymorphism?
* for code reusability: reusing the fields and methods
* 

3. Abstraction: Abstraction is the process of hiding certain details and showing only required 
properties and methods to the user

*Abstraction can be achieved with either abstract classes or interfaces
* To use abstraction we need to use the keyword "abstract" (if implementing is done via classes)
* abstract keyword is used for both classes and methods
* a. Abstract class: It is a restricted class that cannot be used to create objects
* Ex: currentUser obj1 = new currentUser();   //Throws an error if currentUser is abstract class
* 
* b. Abstract method: It can be only used inside an abstract class.
* It doesn't have a body in the parent class
* The body is provided in the child class
* 
* Ex: john obj1 = new john();
*     obj1.eat();  //This method exists in parent class
*     obj1.run();  //This method is abstract method inside parent class, and the body 
*                   will be provided in the child class
*                   
* Why to use abstract classes and methods:
* To achieve security by hiding certain details and only show important details
* 
* 
* 
* //Task:
* Add a delete user page for admin, consisting of an input field - email id. If the email id is
* found in the users list,then delete the user and display the updated user list in a table
* , if not, display the user is not found.
* 
* 
*  git remote set-url origin https://git-repo/new-repository.git
*  
*  Interfaces: It is an other way to achieve abstraction
*  
*  
*  What is an inteface? 
*  It is a completely abstract class, but the can only contain abstract methods and properties
*  
*  function eat(){  //code }
*  function abstract eat();
*  
*  interface interfaceName {
*       abstract methods and properties//
*  }
*  
*  abstract class --> both abstract methods and non-abstract methods
*  interface --> only abstract methods and properties but not fields
*  
*  ** If parent and child both are classes, then it inherits
*  ** If parent is interface and child is a class, then it implements
*  
*  Ex: interface IUser {
*       void run();
*       void eat();
*  }
*  
*  class Admin : IUser
*  {
*       public void run(){
*           //console.write
*       }
*  }
*  
*  Interfaces cannot be used to create objects
*  Interface methods cannot have a body
*  To implements the abstract methods inside interface we have to override them, but the override
*  keyword is not required in the declaration
*  Interface members (prop + methods) are by default public and abstract
*  Interface cannot contain a constructor
*  
*  Why interface?
*  a. To achieve security - to hide certain details
*  b. We cannot acheive multiple inheritance using classes, but can achieve that using interfaces
*  
*  
*  Example for b:
*  
*  class A { //code //run() }
*  
*  class B { //code //eat() }
*  
*  //Multiple inheritance - cannot be done achieved in c#
*  class C : A, B
*  { //code }
*  
*  
*  //To achieve this we can use multiple interfaces
*  
*  interface IA {  //abstract run() }
*  
*  interface IB {  //abstract eat() }
*  
*  class C: IA, IB
*  {
*       run(){ //code  }
*       eat(){  //code }
*  }
*  
 */
