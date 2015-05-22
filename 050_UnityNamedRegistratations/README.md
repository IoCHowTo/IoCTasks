#Task 5: Microsoft Unity named registrations

## Named registrations of services

* If an interface has multiple implementations (strategies) a named registration
  can be used.
* A concrete strategy can be later specified either as an argument of 
  ```DependencyAttribute``` or ```IUnityContainer.Resolve()``` method.
* This can be also used for plugins or modules:
  * Microsoft Unity allows you to enumerate all registrations of an interface 
    via ```IUnityContainer.ResolveAll()``` method.

## How to start?

1. The project is using constructor and property injection.
2. Get familiar with project 050_UnityNamedRegistrations.
3. At first get the project working using ```ConsoleResultWriter```:
   * Review the ```Bootstrapper``` class and perform necessary registration 
     changes.
4. Then try to use ```ConsolidatedResultWriter``` class (its purpose is to write
   output to both - console and file):
   * You will need to register new named dependencies in ```Bootstrapper``` 
     class.
   * Also there is related issue in specifaction of dependencies within the 
     ```ConsolidatedResultWriter``` class.

## Extras

* Try implement more operations via the ```IOperation``` and add respective 
  registrations in order to support them.

## Solution

* For more info about the sample solution please see IoCTaskSolutions, project 
  050_UnityNamedRegistrations.
* Read the comments throughout the code carefully, they contain important 
  informations in regards of inversion of control, dependency injection and 
  general coding guide.
