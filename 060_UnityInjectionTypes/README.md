#Task 5: Microsoft Unity and Various Injection Types

## Supported injection types

* Constructor injection
  * Dependencies are specified as parameters of the constructor
  * If multiple constructors exist on the class by default the constructor with most dependencies is used
  * or you can define a constructor by decorating it with ```InjectionConstructorAttribute```
* Property injection
  * Dependency is injected into a property
  * An auto-property can be used
  * Property needs to be decorated with ```DependencyAttribute```
  * While it is technically possible to perform some additional logic in property setter try to avoid it and instead use injection method
  * Should be used when the dependency is considered as optional
* Injection method
  * Similar to constructor injection
  * Mutliple dependencies can be defined on the method
  * Method needs to be decorated with ```InjectionMethodAttribute```
  * Use when you need perform some additional setup which is not well suitable for the constructor
* Injection factory
  * For complex object initialization you can use an injection factory see ```InjectionFactory```
  * Do not register additional dependencies when using an injection factory


## How to start?

1. The project is using constructor and property injection
2. Get familiar with project 060_UnityInjectionTypes
3. At first get the project working using ```ConsoleResultWriter```
   * Review the ```Bootstrapper``` class and perform necessary registration changes
4. Then try to use ```ConsolidatedResultWriter``` class (its purpose is to write output to both - console and file)
   * You will need to register new named dependencies in ```Bootstrapper``` class
   * Also there is related issue in specifaction of dependencies within the ```ConsolidatedResultWriter``` class

## Extras

* Try implement more operations via the ```IOperation``` and add respective registrations in order to support them

## Solution

* For more info about the sample solution please see IoCTaskSolutions, project 050_UnityNamedRegistrations.
* Read the comments throughout the code carefully, they contain important informations in regards of inversion of control, dependency injection and general coding guide.
