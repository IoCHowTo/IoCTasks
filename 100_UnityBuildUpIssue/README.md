#Task 9: Microsoft Unity and BuildUp method issues

## BuildUp method

* In some situations it is necessary to instantiate a class manually in the code via ```new``` operator.
  * For example when specifying some argument like file name etc.
* But the class itself still can have dependencies which can be resolved via IoC container.
* Microsoft Unity supports this scenario via its ```IUnityContainer.BuildUp()``` method:
  * Please note that if the class you are trying to *build-up* is not registered within the unity the dependencies are resolved using the type of argument passed to the method.

## How to start?

1. The project is currently using constructor injection.
2. Get familiar with project 100_UnityBuildUpIssue.
3. Run the application - you should face a ```NullReferenceException```.
4. Try to fix the issue using your previous experience/knowledge.

## Extras

* There are two ways how to fix the issue - try to find both of them.

## Solution

* For more info about the sample solution please see IoCTaskSolutions, project 100_UnityBuildUpIssue.
* Read the comments throughout the code carefully, they contain important informations in regards inversion of control and dependency injection.
