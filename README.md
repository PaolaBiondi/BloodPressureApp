---
name: .NET MAUI - Blood Pressure App
description: Blood pressure app that stores your measurements in your mobile, tabled or PC.
languages:
- csharp
- xaml
products:
- dotnet-maui 
---

# BloodPressureLogApp (Demo App)  

This app demonstrates MVVM pattern using various MAUI techniques for building a desktop and mobile app. There are examples how to use DI with app shell, how to navigate thru pages, different controls, data templates, ORM .MAUI community toolkit. 
It was enriched with data plot using SyncFusion chart control. 
App is designed to log blood pressure measurements. For measuremens which exceed set threshold, item will be highlighted in red. 

<img src="splash.jpg" width="400px"/>
<img src="start.gif" width="400px"/>
<img src="log.jpg" width="400px">
<img src="swipegesture.jpg" width="400px">
<img src="edit.jpg" width="400px">


Project 'BloodPressureLogApp' has the following package references:  
[net8.0-android34.0]: 
   Top-level Package                               Requested          Resolved        
   > CommunityToolkit.Maui                         7.0.1              7.0.1           
   > CommunityToolkit.Mvvm                         8.2.2              8.2.2           
   > Microsoft.Extensions.Logging.Debug            8.0.0              8.0.0           
   > Microsoft.Maui.Controls                       8.0.10             8.0.10          
   > Microsoft.Maui.Controls.Compatibility         8.0.10             8.0.10          
   > Microsoft.NET.ILLink.Tasks              (A)   [8.0.2, )          8.0.2           
   > SkiaSharp.Extended.UI.Maui                    2.0.0-preview.92   2.0.0-preview.92
   > Syncfusion.Maui.Charts                        25.1.35            25.1.35        

   [net8.0-ios17.2]: 
   Top-level Package                               Requested          Resolved        
   > CommunityToolkit.Maui                         7.0.1              7.0.1           
   > CommunityToolkit.Mvvm                         8.2.2              8.2.2           
   > Microsoft.Extensions.Logging.Debug            8.0.0              8.0.0           
   > Microsoft.Maui.Controls                       8.0.10             8.0.10          
   > Microsoft.Maui.Controls.Compatibility         8.0.10             8.0.10          
   > Microsoft.NET.ILLink.Tasks              (A)   [8.0.2, )          8.0.2           
   > SkiaSharp.Extended.UI.Maui                    2.0.0-preview.92   2.0.0-preview.92  
   > Syncfusion.Maui.Charts                        25.1.35            25.1.35        

   [net8.0-maccatalyst17.2]: 
   Top-level Package                               Requested          Resolved        
   > CommunityToolkit.Maui                         7.0.1              7.0.1           
   > CommunityToolkit.Mvvm                         8.2.2              8.2.2           
   > Microsoft.Extensions.Logging.Debug            8.0.0              8.0.0           
   > Microsoft.Maui.Controls                       8.0.10             8.0.10          
   > Microsoft.Maui.Controls.Compatibility         8.0.10             8.0.10          
   > Microsoft.NET.ILLink.Tasks              (A)   [8.0.2, )          8.0.2           
   > SkiaSharp.Extended.UI.Maui                    2.0.0-preview.92   2.0.0-preview.92  
   > Syncfusion.Maui.Charts                        25.1.35            25.1.35        

   [net8.0-windows10.0.19041]: 
   Top-level Package                            Requested          Resolved        
   > CommunityToolkit.Maui                      7.0.1              7.0.1           
   > CommunityToolkit.Mvvm                      8.2.2              8.2.2           
   > Microsoft.Extensions.Logging.Debug         8.0.0              8.0.0           
   > Microsoft.Maui.Controls                    8.0.10             8.0.10          
   > Microsoft.Maui.Controls.Compatibility      8.0.10             8.0.10          
   > SkiaSharp.Extended.UI.Maui                 2.0.0-preview.92   2.0.0-preview.92  
   > Syncfusion.Maui.Charts                        25.1.35            25.1.35        

Project 'BloodPressure.Domain' has the following package references
   [net8.0-android34.0]: 
   Top-level Package                            Requested   Resolved
   > Microsoft.Maui.Controls                    8.0.10      8.0.10  
   > Microsoft.Maui.Controls.Compatibility      8.0.10      8.0.10  

   [net8.0-ios17.2]: 
   Top-level Package                               Requested   Resolved
   > Microsoft.Maui.Controls                       8.0.10      8.0.10  
   > Microsoft.Maui.Controls.Compatibility         8.0.10      8.0.10  
   > Microsoft.NET.ILLink.Tasks              (A)   [8.0.2, )   8.0.2   

   [net8.0-maccatalyst17.2]: 
   Top-level Package                               Requested   Resolved
   > Microsoft.Maui.Controls                       8.0.10      8.0.10  
   > Microsoft.Maui.Controls.Compatibility         8.0.10      8.0.10  
   > Microsoft.NET.ILLink.Tasks              (A)   [8.0.2, )   8.0.2   

   [net8.0-windows10.0.19041]: 
   Top-level Package                            Requested   Resolved
   > Microsoft.Maui.Controls                    8.0.10      8.0.10  
   > Microsoft.Maui.Controls.Compatibility      8.0.10      8.0.10  

Project 'BloodPressure.Infrastructure.Persistence.EFC.SQLite' has the following package references
   [net8.0-android34.0]: 
   Top-level Package                            Requested   Resolved
   > Microsoft.EntityFrameworkCore.Sqlite       8.0.3       8.0.3   
   > Microsoft.Maui.Controls                    8.0.10      8.0.10  
   > Microsoft.Maui.Controls.Compatibility      8.0.10      8.0.10  

   [net8.0-ios17.2]: 
   Top-level Package                               Requested   Resolved
   > Microsoft.EntityFrameworkCore.Sqlite          8.0.3       8.0.3   
   > Microsoft.Maui.Controls                       8.0.10      8.0.10  
   > Microsoft.Maui.Controls.Compatibility         8.0.10      8.0.10  
   > Microsoft.NET.ILLink.Tasks              (A)   [8.0.2, )   8.0.2   

   [net8.0-maccatalyst17.2]: 
   Top-level Package                               Requested   Resolved
   > Microsoft.EntityFrameworkCore.Sqlite          8.0.3       8.0.3   
   > Microsoft.Maui.Controls                       8.0.10      8.0.10  
   > Microsoft.Maui.Controls.Compatibility         8.0.10      8.0.10  
   > Microsoft.NET.ILLink.Tasks              (A)   [8.0.2, )   8.0.2   

   [net8.0-windows10.0.19041]: 
   Top-level Package                            Requested   Resolved
   > Microsoft.EntityFrameworkCore.Sqlite       8.0.3       8.0.3   
   > Microsoft.Maui.Controls                    8.0.10      8.0.10  
   > Microsoft.Maui.Controls.Compatibility      8.0.10      8.0.10  

Project 'BloodPressure.UseCases' has the following package references
   [net8.0-android34.0]: 
   Top-level Package                            Requested   Resolved
   > Microsoft.Maui.Controls                    8.0.10      8.0.10  
   > Microsoft.Maui.Controls.Compatibility      8.0.10      8.0.10  

   [net8.0-ios17.2]: 
   Top-level Package                               Requested   Resolved
   > Microsoft.Maui.Controls                       8.0.10      8.0.10  
   > Microsoft.Maui.Controls.Compatibility         8.0.10      8.0.10  
   > Microsoft.NET.ILLink.Tasks              (A)   [8.0.2, )   8.0.2   

   [net8.0-maccatalyst17.2]: 
   Top-level Package                               Requested   Resolved
   > Microsoft.Maui.Controls                       8.0.10      8.0.10  
   > Microsoft.Maui.Controls.Compatibility         8.0.10      8.0.10  
   > Microsoft.NET.ILLink.Tasks              (A)   [8.0.2, )   8.0.2   

   [net8.0-windows10.0.19041]: 
   Top-level Package                            Requested   Resolved
   > Microsoft.Maui.Controls                    8.0.10      8.0.10  
   > Microsoft.Maui.Controls.Compatibility      8.0.10      8.0.10  


## SyncFusion Cartesian Chart  

Official documentation can be found under [link](https://help.syncfusion.com/maui/cartesian-charts/overview#key-features).  

```
dotnet add package  Syncfusion.Maui.Charts
``` 

**N.B.** SyncFusion cannot cast DateTimeOffset so it requires additional non mapped field which gets DateTime property from original value.   

### Licensing  
Add `Syncfusion.Licensing.SyncfusionLicenseProvider.RegisterLicense("YOUR KEY");` during initialization of app.  
Claimed for community license. Claim license key under syncfusion profile, Licese & Downloads -> Claim License Key tab.  

---
## Useful links 
[Icons](https://fontello.com/)  
[Animations](https://lottiefiles.com/)  
[.NET Examples](https://github.com/dotnet/maui-samples?tab=readme-ov-file)  
[ MAUI Behavior toolkit](https://learn.microsoft.com/en-us/dotnet/communitytoolkit/maui/behaviors/numeric-validation-behavior#using-the-numericvalidationbehavior)  
[MicroCharts](https://www.youtube.com/watch?v=yMG8oPIuMig)  
[MicroCharts Gerald's example github](https://github.com/jfversluis/MauiMicrochartsSample/)  
[Udemy Frank Liu](https://www.udemy.com/share/1096Xs3@prGNOkbD_3gUDs6ry_OeVllmirlaJIoqxVEwy4kDkSigwtafEMBtbBhZ7luT8Gz-Eg==/)  
[Udemy Hextor Uriel Perez](https://www.udemy.com/share/106HTg3@q_PJcsRGyH4j3uuUMTA4a6ZORCmO0H69OfESpB0kmOfGdTS_UY-d_Se1oyU092RNaQ==/)
[mp4 to gif](https://ezgif.com/)  
[SyncFusion licensing](https://help.syncfusion.com/maui/licensing/overview#difference-between-unlock-key-and-license-key)  
## Errors  
Could not find Android Resource '@styleable/SKCanvasView'. Please update to add the missing resource.

Could not find Android Resource '@styleable/SKCanvasView_ignorePixelScaling'. Please update @(AndroidResource) to add the missing resource.  
Fix: [link](https://github.com/dotnet/maui/issues/19645#issuecomment-1924235196)  

Could not start Android emulator
Fix: [Enable Windows Hyper-V otherwise Android emulator won't start](https://learn.microsoft.com/en-us/dotnet/maui/android/emulator/hardware-acceleration?view=net-maui-8.0#enable-hyper-v-acceleration-in-windows).  
Hyper-V and Windows Hypervisor Platfporm feature shoult be enabled
