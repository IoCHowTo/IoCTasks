#Task 11: Microsoft Unity Hang During Container Disposal

## Container disposal

* The purpose of container disposal is to free unused resources.
* Since the container can be used to manage object lifetime for some of the
  lifetime managers the disposal is also responsible for freeing up the
  resources managed by it (like ```ContainerControlledLifetimeManager```).
* Child containers obviously have different lifetime than parent containers.

## How to start?

1. The project is currently using constructor injection.
2. Get familiar with project 120_UnityContainerDisposalHang.
3. The project is using a background thread file writer.
4. Program never exits.
  * Debug the issue and suggest a suitable fix for it.

## Solution

* For more info about the sample solution please see IoCTaskSolutions, project
  120_UnityContainerDisposalHang.
* Read the comments throughout the code carefully, they contain important 
  informations in regards of inversion of control, dependency injection and 
  general coding guide.
