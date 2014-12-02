#Task 2: IoC with Microsoft Unity

## IoC Container
* IoC Container keeps track of implementors of interfaces (services)
* It helps you wire objects together without doing so explicitly.
* It can provide even more - for example lifetime management.
* When registering and consuming dependencies as interfaces you do not have to worry who the implementor is and how to construct it - container takes the responsibility and does things for you.
* Dependencies defined as interfaces have some benefits:
  * Classes are much easier to unit test.
  * Changing the implementation (strategy) is just matter of registration into IoC container.
* Adding a new dependency to any of classes is as simple as adding a new interface to constructor (or respectively as a parameter to an injection method or dependency property).

## How to start?

1. The project is currently using constructor injection,
2. Get familiar with project 020_IoCWithUnity,
3. Identify all interfaces and their implementors,
4. Find the ```Bootstrapper``` class,
5. Properly implement its ```SetupContainer()``` method.

## Extras

* Feel free to modify the solution by providing new implementations of interface IOperation, e.g. Minus.
* Try implement another ```IResultWriter``` which will write result to a file name

## Solution

* For more info about the sample solution please see IoCTaskSolutions, project 020_IoCWithUnity.
* Read the comments throughout the code carefully, they contain important informations in regards inversion of control and dependency injection.
