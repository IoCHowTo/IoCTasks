#Task 3: Microsoft Unity Child Containers

## Child containers

* Child containers serve for two purposes
  * Allow to define additional dependencies just for a define execution scope
  * Re-define dependencies previously defined within one of the parent containers
  * Limit the lifetime of the singleton objects managed by the given instance of Microsoft Unity container
* When you will resolve an implementation of ```IUnityContainer``` by default it always points to the instance of Microsoft Unity used for resolution
* In order to create a child container call ```IUnityContainer.CreateChildContainer()``` method on the desired parent

## How to start?

1. The project is currently using constructor injection,
2. Get familiar with project 030_UnityChildContainers,
3. Your goal is to write result into the console and into a statically named file
4. Find the ```IResultWriter``` interface
   * It currently has a single implementation which is ```ConsoleResultWriter```
   * Develop a new implementation which will write result into a statically named file inside the application start folder
   * Register your new implementation inside the ```Bootstrapper``` class within the ```SetupChildContainer``` method
5. Inside the ```Program``` class, ```Main``` method create a child container and initialize it using ```Bootstrapper``` class
6. Call the ```PerformCalculation``` method using the child container

## Extras

* You can implement new operations (like minus) and see how the different places of ```Boostrapper``` class (```SetupContainer``` vs. ```SetupChildContainer``` methods) change the behavior of Microsoft Unity

## Solution

* For more info about the sample solution please see IoCTaskSolutions, project 030_UnityLifetimeManagement.
* Read the comments throughout the code carefully, they contain important informations in regards of inversion of control, dependency injection and general coding guide.
