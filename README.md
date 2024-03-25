# Getting Started with the .NET MAUI Rating Control

A quick-start project that helps you to integrate a MAUI Rating control in the .NET MAUI application.This project contains code to change the control’s precision mode, modify the rating item shape, restrict interaction in the control, and customize its appearance.

Documentation: https://help.syncfusion.com/maui/rating/getting-started

## Project pre-requisites

Make sure that you have the compatible versions of Visual Studio with .NET MAUI workloads and .NET SDK version in your machine before starting to work on this project.

## How to run this application?

To run this application, you need to first clone the getting-started-with-the-dotnet-maui-rating-control repository and then open it in Visual Studio 2022. Now, simply build and run your project to view the output.
1. Clone the sample and open it in Visual Studio.

   *Note: If you download the sample using the "Download ZIP" option, right-click it, select Properties, and then select Unblock.*

2. Register your license key in the App.cs file as demonstrated in the following code.

        public App()
        {
            //Register Syncfusion license
            Syncfusion.Licensing.SyncfusionLicenseProvider.RegisterLicense("YOUR LICENSE KEY");

            InitializeComponent();

            MainPage = new NavigationPage(new MainPage());
        }

4. Set any one of the platform specific projects (iOS, Android or UWP) as a start-up project.
5. Clean and build the application.
6. Run the application.

## License

Syncfusion has no liability for any damage or consequence that may arise by using or viewing the samples. The samples are for demonstrative purposes, and if you choose to use or access the samples, you agree to not hold Syncfusion liable, in any form, for any damage that is related to use, for accessing, or viewing the samples. By accessing, viewing, or seeing the samples, you acknowledge and agree Syncfusion’s samples will not allow you seek injunctive relief in any form for any claim related to the sample. If you do not agree to this, do not view, access, utilize, or otherwise do anything with Syncfusion’s samples.
## Adding a .NET MAUI Rating reference
Syncfusion .NET MAUI controls are available in Nuget.org. To add .NET MAUI Rating control to your project, open the NuGet package manager in Visual Studio, search for Syncfusion.Maui.Inputs and then install it.

**Step 1**: Create a .NET MAUI application project in Visual Studio 2022.

**Step 2**: Add the [Syncfusion.Maui.Core](https://www.nuget.org/packages/Syncfusion.Maui.Core/) Nuget to the project from [nuget.org](https://www.nuget.org/).

**Step 3**: In the MauiProgram.cs file, register the Syncfusion.Maui.Core handler as follows.

**C#**
```
using Syncfusion.Maui.Core.Hosting;
namespace Rating;
public static class MauiProgram
{
    public static MauiApp CreateMauiApp()
    {
        var builder = MauiApp.CreateBuilder();
        builder
            .UseMauiApp<App>()
            .ConfigureSyncfusionCore()
            .ConfigureFonts(fonts =>
            {
                fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
            });
        return builder.Build();
    }
}
```
## Customization in Rating control
### To modify space between rating items
**XAML**
 ```
<ContentPage.Content>
        <rating:SfRating Value="3"
                         ItemSpacing="20"/>
</ContentPage.Content>
 ```

**OUTPUT**

 ![kbrating.png](https://support.bolddesk.com/kb/agent/attachment/article/13405/inline?token=eyJhbGciOiJodHRwOi8vd3d3LnczLm9yZy8yMDAxLzA0L3htbGRzaWctbW9yZSNobWFjLXNoYTI1NiIsInR5cCI6IkpXVCJ9.eyJpZCI6Ijk3NjQiLCJvcmdpZCI6IjMiLCJpc3MiOiJzdXBwb3J0LmJvbGRkZXNrLmNvbSJ9.kmU7cItaHdibrcok7fbgi0NnGA1QkhkchiiNkSXXmns)

### To change the color of rating items

 **XAML**
 ```
<ContentPage.Content>
     <rating:SfRating Value="3">
        <rating:SfRating.RatingSettings>
            <rating:RatingSettings RatedFill="Red" UnratedFill="Black"/>
        </rating:SfRating.RatingSettings>
    </rating:SfRating>
</ContentPage.Content>
 ```
**OUTPUT**

 ![ratedcolorKB.jpg](https://support.bolddesk.com/kb/agent/attachment/article/13471/inline?token=eyJhbGciOiJodHRwOi8vd3d3LnczLm9yZy8yMDAxLzA0L3htbGRzaWctbW9yZSNobWFjLXNoYTI1NiIsInR5cCI6IkpXVCJ9.eyJpZCI6IjEwMDUwIiwib3JnaWQiOiIzIiwiaXNzIjoic3VwcG9ydC5ib2xkZGVzay5jb20ifQ.5iXTpvqeow3vq-_gT7faNhKx5FYVgB3bdAhTRtghwds)
