#Task 1: IoC without Microsoft Unity

Primary goal is to implement new class representing IoC container without actually using Microsoft Unity or any other IoC 3rd party libraries. 
To achieve this goal, please review the following points:
* IoC container holds or creates instances of various classes and provides them on demand throughout the application.
  * Focus solely on object creation within this task.
* Typically, IoC container creates new instances of objects based on some kind of type information, which is usually parameter of method responsible for creating new instances.
  * For this simple task you can provide this type information even in a form of string.


## How to start?

1. Get familiar with project 010_IoCWithoutUnity.
2. Identify places where introducing interfaces could be beneficial, you can get inspired by pre-existing interface IOperation.
3. Use newly introduced interfaces wherever possible.
4. Introduce new class called Container which will take over the responsibility of creating new objects based on type (interface name) information.
  * You can get inspired by the class OperatorFactory.
  * Don't be afraid to have a Create method returning instances of class object, you can cast them later.
5. Locate places where objects are getting created and alter the code to create instances using instance of class Container that you just implemented.

## Extras

Feel free to modify the solution by providing new implementations of interface IOperation, e.g. Minus.

## Solution

* For more info about the sample solution please see IoCTaskSolutions, project 010_IoCWithoutUnity.
* read the comments throughout the code carefully, they contain important informations in regards inversion of control and dependency injection.