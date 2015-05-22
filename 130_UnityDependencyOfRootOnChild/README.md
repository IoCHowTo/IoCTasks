#Task 13: Microsoft Unity And Invalid Dependencies Between Parent And Child 
Container

## Dependencies between parent and child container

* In general you can have setup anything in child container to depend on
  anything on parent container which is perfectly valid.
* Unfortunately it is possible to get into oposite situation when you setup
  a dependency in parent container which will get injected a child container
  dependency.

  This has some related issues:

  * If you resolve the parent dependency then the injected reference depends on used
    child container and its configuration.
  * In the case that such dependency is a singleton the injected dependency will
    come from first used child container.
  * And even more - if the dependency in child container is a disposable object
    the injected object may become invalid during the child container disposal.

* You may check 
  [https://github.com/voloda/UnityRegistrationValidator](https://github.com/voloda/UnityRegistrationValidator)
  to see how you can try prevent this.

## How to start?

1. The project is currently using constructor injection.
   * Since the registrations are very simple project does not have 
     any ```Bootstrapper```.
2. Get familiar with project 130_UnityDependencyOfRootOnChild.
3. The project sets several thread to run some complex operation using a remote
   service which construction takes a lot of time.
4. You would have the logging details written into a separate log file per 
   thread.
5. Program randomly fails after executing some of the background thread tasks.
   * Also check the content of logging files - you may find out that it is not
     exactly you may expect.

## Extras

* Try to use the UnityRegistrationValidator extension to see how that can help
  to predict the issue.

## Solution

* For more info about the sample solution please see IoCTaskSolutions, project
  130_UnityDependencyOfRootOnChild.
* Read the comments throughout the code carefully, they contain important 
  informations in regards of inversion of control, dependency injection and 
  general coding guide.
