# Getting Started with the .NET MAUI Rating Control

The [.NET MAUI Rating](https://www.syncfusion.com/maui-controls/maui-rating?utm_source=github&utm_medium=listing&utm_campaign=maui-rating-github-samples) control allows users to select a rating value from a group of visual symbols like stars, hearts, or custom shapes. A quick-start project that helps you to integrate a MAUI Rating control in the .NET MAUI application.This project contains code to change the control’s precision mode, modify the rating item shape, restrict interaction in the control, and customize its appearance.

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

## Features and Benefits

## Precision

The .NET MAUI Rating control supports precise ratings to handle full, [half](https://help.syncfusion.com/maui/rating/precision-mode#half?utm_source=github&utm_medium=listing&utm_campaign=maui-rating-github-samples), or [exact](https://help.syncfusion.com/maui/rating/precision-mode#exact?utm_source=github&utm_medium=listing&utm_campaign=maui-rating-github-samples) values.

## Rating shapes

The Rating control in .NET MAUI allows the use of both predefined shapes and [custom shapes](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Inputs.RatingShape.html#Syncfusion_Maui_Inputs_RatingShape_Custom?utm_source=github&utm_medium=listing&utm_campaign=maui-rating-github-samples).

## Set as read-only

The .NET MAUI Rating control can also be used in a read-only state. In this mode, users cannot interact with the control.

## Customization

The .NET MAUI Rating control supports customizing the item color, item border color, [spacing](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.Inputs.SfRating.html#Syncfusion_Maui_Inputs_SfRating_ItemSpacing?utm_source=github&utm_medium=listing&utm_campaign=maui-rating-github-samples), selection color, and more, enabling the items to fit the application theme.

## Related links
[Learn More about .NET MAUI Rating](https://www.syncfusion.com/maui-controls/maui-rating?utm_source=github&utm_medium=listing&utm_campaign=maui-rating-github-samples)
[Download Free Trial](https://www.syncfusion.com/downloads/maui?utm_source=github&utm_medium=listing&utm_campaign=maui-rating-github-samples)
[Pricing](https://www.syncfusion.com/sales/teamlicense)
[Documentation](https://help.syncfusion.com/maui/rating/getting-started?utm_source=github&utm_medium=listing&utm_campaign=maui-rating-github-samples)
[View Demos](https://github.com/syncfusion/maui-demos/tree/master/MAUI/Inputs/SampleBrowser.Maui.Inputs/Samples/Rating?utm_source=github&utm_medium=listing&utm_campaign=maui-rating-github-samples)
[Community Forums](https://www.syncfusion.com/forums/maui?control=rating)
[Suggest a feature or report a bug](https://www.syncfusion.com/feedback/maui?control=sfrating)
[Online example](https://github.com/SyncfusionExamples/getting-started-with-the-dotnet-maui-rating-control?utm_source=github&utm_medium=listing&utm_campaign=maui-rating-github-samples)

## About Syncfusion .NET MAUI Rating Control
Syncfusion's [.NET MAUI UI Controls](https://www.syncfusion.com/maui-controls/maui-rating?utm_source=github&utm_medium=listing&utm_campaign=maui-rating-github-samples) library is the only suite that you will ever need to build an application since it contains over 65 high-performance, lightweight, modular, and responsive UI Controls in a single package. In addition to Rating, we provide popular .NET MAUI Controls such as [DataGrid](https://www.syncfusion.com/maui-controls/maui-datagrid?utm_source=github&utm_medium=listing&utm_campaign=maui-rating-github-samples), [Charts](https://www.syncfusion.com/maui-controls/maui-cartesian-charts?utm_source=github&utm_medium=listing&utm_campaign=maui-rating-github-samples), [Scheduler](https://www.syncfusion.com/maui-controls/maui-scheduler?utm_source=github&utm_medium=listing&utm_campaign=maui-rating-github-samples), [ListView](https://www.syncfusion.com/maui-controls/maui-listview?utm_source=github&utm_medium=listing&utm_campaign=maui-rating-github-samples), and [Excel Library](https://www.syncfusion.com/document-processing/excel-framework/maui?utm_source=github&utm_medium=listing&utm_campaign=maui-rating-github-samples).

### About Syncfusion
Founded in 2001 and headquartered in Research Triangle Park, N.C., Syncfusion has more than 29,000 customers and more than 1 million users, including large financial institutions, Fortune 500 companies, and global IT consultancies.

Today, we provide 1900+ components and frameworks for web [Blazor](https://www.syncfusion.com/blazor-components?utm_source=github&utm_medium=listing&utm_campaign=maui-rating-github-samples), [ASP.NET Core](https://www.syncfusion.com/aspnet-core-ui-controls?utm_source=github&utm_medium=listing&utm_campaign=maui-rating-github-samples), [ASP.NET MVC](https://www.syncfusion.com/aspnet-mvc-ui-controls?utm_source=github&utm_medium=listing&utm_campaign=maui-rating-github-samples), [ASP.NET WebForms](https://www.syncfusion.com/jquery/aspnet-webforms-ui-controls?utm_source=github&utm_medium=listing&utm_campaign=maui-rating-github-samples), [JavaScript](https://www.syncfusion.com/javascript-ui-controls?utm_source=github&utm_medium=listing&utm_campaign=maui-rating-github-samples), [Angular](https://www.syncfusion.com/angular-components?utm_source=github&utm_medium=listing&utm_campaign=maui-rating-github-samples), [React](https://www.syncfusion.com/react-components?utm_source=github&utm_medium=listing&utm_campaign=maui-rating-github-samples), [Vue](https://www.syncfusion.com/vue-components?utm_source=github&utm_medium=listing&utm_campaign=maui-rating-github-samples), and [Flutter](https://www.syncfusion.com/flutter-widgets?utm_source=github&utm_medium=listing&utm_campaign=maui-rating-github-samples), mobile ([Xamarin](https://www.syncfusion.com/xamarin-ui-controls?utm_source=github&utm_medium=listing&utm_campaign=maui-rating-github-samples), [Flutter](https://www.syncfusion.com/flutter-widgets?utm_source=github&utm_medium=listing&utm_campaign=maui-rating-github-samples), [UWP](https://www.syncfusion.com/uwp-ui-controls?utm_source=github&utm_medium=listing&utm_campaign=maui-rating-github-samples), [JavaScript](https://www.syncfusion.com/javascript-ui-controls?utm_source=github&utm_medium=listing&utm_campaign=maui-rating-github-samples), and [.NET MAUI](https://www.syncfusion.com/maui-controls?utm_source=github&utm_medium=listing&utm_campaign=maui-rating-github-samples), and desktop development ([WinForms](https://www.syncfusion.com/winforms-ui-controls?utm_source=github&utm_medium=listing&utm_campaign=maui-rating-github-samples), [WPF](https://www.syncfusion.com/wpf-controls?utm_source=github&utm_medium=listing&utm_campaign=maui-rating-github-samples), [WinUI](https://www.syncfusion.com/winui-controls?utm_source=github&utm_medium=listing&utm_campaign=maui-rating-github-samples), [Flutter](https://www.syncfusion.com/flutter-widgets?utm_source=github&utm_medium=listing&utm_campaign=maui-rating-github-samples), [UWP](https://www.syncfusion.com/uwp-ui-controls?utm_source=github&utm_medium=listing&utm_campaign=maui-rating-github-samples), and [.NET MAUI](https://www.syncfusion.com/maui-controls?utm_source=github&utm_medium=listing&utm_campaign=maui-rating-github-samples). We provide ready-to-deploy enterprise software for dashboards, reports, data integration, and big data processing. Many customers have saved millions in licensing fees by deploying our software.

<hr style="height:0.3px;border:none;color:lightgrey;background-color:lightgrey;" />

<p align="center">
<a href="mailto:sales@syncfusion.com?Subject=Syncfusion .NET MAUI Rating - GitHub" target="_top">sales@syncfusion.com</a> | <a href="https://www.syncfusion.com?utm_source=github&utm_medium=listing&utm_campaign=maui-rating-github-samples">www.syncfusion.com</a> | Toll Free: 1-888-9 DOTNET <br>
</p>
