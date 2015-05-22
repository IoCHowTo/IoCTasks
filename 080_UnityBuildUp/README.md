#Task 8: Microsoft Unity and BuildUp method

## BuildUp method

* In some situations it is necessary to instantiate a class manually in the code
  via ```new``` operator.
  * For example when specifying some argument like file name etc.
* But the class itself still can have dependencies which can be resolved via IoC
  container.
* Microsoft Unity supports this scenario via its ```IUnityContainer.BuildUp()```
  method:
  * Please note that if the class you are trying to *build-up* is not registered
    within the unity the dependencies are resolved using the type of argument 
	passed to the method.

## How to start?

1. The project is currently using constructor injection.
2. Get familiar with project 080_UnityBuildUp.
3. Find the ```ConsoleAndFileResultWriter``` class:
  * Alter the class constructor so it accepts only an output file name.
  * Define a property or method injection to get ```IConsoleResultWriter``` 
    injected.
4. Open ```Program``` class and adjust the code related to 
  ```ConsoleAndFileResultWriter``` class instantiation so it benefits from 
  ```IUnityContainer.BuildUp()``` method.

## Solution

* For more info about the sample solution please see IoCTaskSolutions, project
  080_UnityBuildUp.
* Read the comments throughout the code carefully, they contain important 
  informations in regards inversion of control and dependency injection.
