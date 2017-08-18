# TinyNavigationHelper
TinyNavigationHelper is a library that is created for you that want to abstract the navigation without installing a bigger MVVM framework. 

Today there are only an implementation for Xamarin.Forms, but it created in a way that it will be possible to create implementatons for other platforms as well.

## How to install
For your Xamarin.Forms project install the package from NuGet:

```
Install-Package TinyNavigationHelper.Forms -pre
```

If you want to use navigation from a project that not has references to Xamarin.Forms (for example if you have your ViewModels in a separete project for use on other platforms), install the abstraction package for that project.

```
Install-Package TinyNavigationHelper.Abstraction -pre
```

## How to configure navigation for Xamarin.Forms

```cs
var navigationHelper = new NavigationHelper(this);
navigationHelper.RegisterView<MainView>("MainView");
```
If you want to use it with an IoC instance you need to register the specific instance in the IoC container. The example below is how to register in Autofac, but you can use the container you prefer.

```cs
var containerBuilder = new ContainerBuilder();
containerBuilder.RegisterInstance<INavigationHelper>(navigationHelper);

var container = containerBuilder.Build();
```
## How to use TinyNavigationHelper
There are two ways to use the navigation helper. To resolve the INavigationHelper interface via foreample constructor inbjection, or to access it via the Current property on the NavigationHelper class in the TinyNavigationHelper.Abstraction namespace.

```cs
var navigationHelper = NavigationHelper.Current;
```
var navigationHelper = NavigationHelper.Current;
