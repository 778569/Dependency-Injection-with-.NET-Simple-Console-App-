Type of Dependency injection
* Constructor Injection (Inject to Class A contractor)
* Property Injection (Inject to Class A Property)
* Method Injection (Inject to Class A Method ) <br><br>
![image](https://github.com/778569/Dependency-Injection-with-.NET-Simple-Console-App-/assets/52319671/25ed3c6f-53f9-42c9-85a5-648343b5e2ee)<br><br>


The code snippet you sent me defines a ServiceCollection which is used to register services that can be injected into other parts of the application. The AddSingleton(), AddScoped(), and AddTransient() methods are used to specify the lifetime of the registered services.

* AddSingleton() registers a service that will be created only once and used throughout the application.
* AddScoped() registers a service that will be created once per scope. A scope is typically a request or a web session.
* AddTransient() registers a service that will be created each time it is injected.
The specific code you sent me does not register any services, but it shows the basic syntax for how to register services with different lifetimes.

Example -<br><br>
![image](https://github.com/778569/Dependency-Injection-with-.NET-Simple-Console-App-/assets/52319671/9c3fa7e0-5427-4954-beee-f7adca93d5cd)<br><br>

Resule - <br><br>

![image](https://github.com/778569/Dependency-Injection-with-.NET-Simple-Console-App-/assets/52319671/f5438766-8ef2-4251-a883-4e98ad72a9ae) <br><br>


