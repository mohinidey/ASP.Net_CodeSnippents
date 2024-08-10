// See https://aka.ms/new-console-template for more information
using SingletonDEmo;


//FirstInstanceCall();
//SecondInstanceCall();
/*
 * output - 
 * counter - 1
 * First Instance Message
 * Seond JInstance Message
 * Since singleton object is used only one instance is created.
 * This code will not work in multithreading.there it will create multiple objects.
 */

Parallel.Invoke(() => FirstInstanceCall(), () => SecondInstanceCall());// to call methods in parellel thread. 

static void FirstInstanceCall()
{
    var x = Singleton.GetInstance;
    x.Print("First instance message");
}

static void SecondInstanceCall()
{
    var y = Singleton.GetInstance;
    y.Print("Second instance message");
}

/*
 * output - 
 * counter - 1
 * First Instance Message
 * Seond JInstance Message
 * Since singleton object is used only one instance is created.
 * This code will not work in multithreading.there it will create multiple objects.
 */
/*
 Characteristics of the Singleton design pattern:
    Single Instance: It ensures that a class has only one instance and provides a global point of access to that instance.
    Global Access: The single instance is globally accessible, allowing clients to access it without instantiating the class.
    Lazy Initialization (Optional): The instantiation of the singleton instance is deferred until it is needed. This is known as lazy initialization and can help improve performance.
    Private Constructor: The class has a private constructor to prevent the direct instantiation of the object from outside the class.
    Static Instance: The Singleton class typically has a static member that holds the reference to the single instance.
 */

