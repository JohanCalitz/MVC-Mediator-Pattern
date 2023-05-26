# MVC_Mediator_Pattern

This app was built using a basic mvc mediator pattern

Defining the Mediator Interface: The IPersonMediator interface was created to define the contract for the mediator. It includes a method signature CreatePerson(string name, int age) that encapsulates the logic for creating a person.

Implementing the Mediator: The PersonMediator class implements the IPersonMediator interface. It contains the logic to create a person. In this example, it receives the person's name and age as parameters and saves the name to a JSON file.

Dependency Injection: The IPersonMediator interface is registered in the ConfigureServices method of the Startup class, ensuring that the PersonMediator is available for dependency injection throughout the application.

Controller Dependency: The HomeController class receives an instance of IPersonMediator through constructor injection. This allows the controller to communicate with the mediator without directly instantiating it.

Overall, the Mediator pattern is achieved by introducing the IPersonMediator interface as a central communication channel between components. The PersonMediator class acts as the mediator, handling the logic related to creating a person. The HomeController acts as the sender, invoking the CreatePerson method on the IPersonMediator interface to create a person. This decouples the sender and receiver, promoting better separation of concerns and modularity in the application.
