# IoCTasks

## Intro

This solution contains a set of projects which should help you understand to following topics:

* IoC/DI (Inversion Of Control/Dependency Injection principles).
* IoC containers.
* Microsoft Unity IoC container.
* It also touches on highly related topic which is Unit testing.

## Motivation
* Provide 'hands-on experience' course on the topics above in form of small coding tasks.
* Help to guys on the team to understand the topic.
* Deliver sample solutions for all tasks which can serve as a reference with intent:
  * At first try to resolve tasks on your own. 
  * If you will get stuck feel free use appropriate sample solution to unblock yourself.
  * After you solved it on your own, look at the sample solution to make sure we understand it in the same way.

## Sources

* The best theoretical source on inversion of control and dependency injection is probably [Martin Fowler's article](http://martinfowler.com/articles/injection.html)
* There is also very useful [StackExchange thread](http://programmers.stackexchange.com/a/205686) 
  which is dedicated to the above mentioned article and is very helpful in understanding that IoC can have many forms
* The rest of sources includes:
  * [MSDN article](http://msdn.microsoft.com/en-us/library/ff921087.aspx)
  * Two CodeProject articles, [DI vs IoC](http://www.codeproject.com/Articles/592372/Dependency-Injection-DI-vs-Inversion-of-Control-IO) 
    and [IoC with examples](http://www.codeproject.com/Articles/380748/Inversion-of-Control-Overview-with-Examples)
  * two PluralSight courses, [one dedicated to IoC in general](http://www.pluralsight.com/courses/inversion-of-control) 
    and [the other in regards of ASP.NET MVC](http://www.pluralsight.com/courses/ioc-aspdotnet-mvc4)
  * short article about [introducing IoC into existing codebases] (http://kozmic.net/2012/10/23/ioc-container-solves-a-problem-you-might-not-have-but-its-a-nice-problem-to-have/)
* Microsoft Unity reference guide on MSDN
  * [MSDN](http://msdn.microsoft.com/en-us/library/dn178463%28v=pandp.30%29.aspx)
* NUnit unit testing framework:
  * [NUnit](http://www.nunit.org)
* Moq mocking framework
  * [Moq](https://github.com/Moq/moq4)

## How to use projects

* Each project is a prepared coding task.
* Each project contains README.md file which provides brief summary of the topic and goals for the task.
* For additional information look into the Microsoft Unity documentation (goal of this project is not to provide reference guide to MS Unity API).
* Simply clone this project (or download it as a .ZIP file) and attempt to solve all individual tasks.
  * If you need some help just reference to [solutions repository](https://github.com/IoCHowTo/IoCTasksSolutions).
* Open the solution in VS2012+ and compile it. The compilation would download dependencies from Nuget (such as Microsoft Unity).
* If you are aware of some interesting challenge in the area feel free to propose a sample tasks with sample solution
  in form of pull request.
