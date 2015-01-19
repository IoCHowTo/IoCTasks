#Task 10: Microsoft Unity and Dependency Resolution Overrides

## Dependency Resolution Overrides

* In some situations you would still benefit from IoC container infrastructure but you would specify one of dependencies manually:
  * For example when specifying some argument like file name etc.
* Microsoft Unity supports this scenario via overloads of ```BuildUp()``` and ```Resolve()``` methods.
* Basic override types:
  * ```ParameterOverride``` for named parameter dependency override.
  * ```DependencyOverride``` for a parameter type dependency override.
  * ```PropertyOverride``` for a property dependency override.
* An override is by default applied to all dependencies being used during the single resolution:
  * Use ```OnType``` method to limit scope of override to particular type only.
* I is *good* to use this feature very carefully and use it just in specific cases:
  * You are basically introducing tight coupling (especially when using overrides based on parameter names).
* It is better not to spread it widely in the codebase and instead to always use it in factories only.

## How to start?

1. The project is currently using constructor injection.
2. Get familiar with project 110_UnityResolutionOverrides.
3. Locate ```Program``` class.
4. Implement resolution of dependency ```IConsoleAndFileResultWriter``` using dependency override for ```fileName``` argument of the injection constructor.

## Extras

* Try to use different override types to get familiar with them.
* Try add another ```string``` argument to ```ConsoleAndFileResultWriter``` class constructor (for example prefix which will be written to output) and see how different override types affect the behavior.

## Solution

* For more info about the sample solution please see IoCTaskSolutions, project 110_UnityResolutionOverrides.
* Read the comments throughout the code carefully, they contain important informations in regards inversion of control and dependency injection.
