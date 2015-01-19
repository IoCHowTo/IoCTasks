#Task 7: Microsoft Unity issue with circular dependencies

## Circular dependencies

* In a larger project it can easily happen that you will introduce a circular dependency.
* Always try to review the dependencies whether this is not by accident and whether it is really necessary.
* The easiest way to deal with it is to inject ```IUnityContainer``` as a dependency and _lazy_ resolve the reference later on demand via ```IUnityContainer.Resolve()```  method call.
* Keep in mind that ```IUnityContainer.ResolveAll()``` method does not include the default (unnamed instance).

## How to start?

1. The project is using constructor injection.
2. Get familiar with project 070_UnityRecursiveRegistrationIssue.
3. If your run the project as-is you can observe ```StackOverflowException``` to be thrown and unhandled.
4. See where this is happening and attempt to fix dependency resolution in a way that all three result writer policies will be used.

## Solution

* For more info about the sample solution please see IoCTaskSolutions, project 070_UnityRecursiveRegistrationIssue.
* Read the comments throughout the code carefully, they contain important informations in regards of inversion of control, dependency injection and general coding guide.
