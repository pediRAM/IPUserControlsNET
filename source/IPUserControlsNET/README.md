# IPUserControlsNET 

[![.NET](https://img.shields.io/badge/.NET%206-512BD4?logo=dotnet&logoColor=fff)](https://versionsof.net/core/6.0/)
[![.NET](https://img.shields.io/badge/.NET%208-512BD4?logo=dotnet&logoColor=fff)](https://versionsof.net/core/8.0/)
[![.NET](https://img.shields.io/badge/.NET%209-512BD4?logo=dotnet&logoColor=fff)](https://versionsof.net/core/9.0/)
[![License](https://img.shields.io/badge/License-MIT-green.svg)](LICENSE)
[![Release](https://img.shields.io/github/release/pediRAM/IPUserControlsNET.svg?sort=semver)](https://github.com/pediRAM/IPUserControlsNET/releases)
[![NuGet](https://img.shields.io/nuget/v/IPUserControlsNET)](https://www.nuget.org/packages/IPUserControlsNET)
<!-- [![.NET](https://img.shields.io/badge/%20E%20U%20👍-0018A8?logo=europeanunion&logoColor=yellow)](https://european-union.europa.eu) -->

This is the english documentation. Following translations are available:
- [普通话 (Mandarin) :cn:](https://github.com/pediRAM/IPUserControlsNET/blob/main/Documentation/Mandarin.md)
- [Español :es:](https://github.com/pediRAM/IPUserControlsNET/blob/main/Documentation/Spanish.md)
- [Pусский :ru:](https://github.com/pediRAM/IPUserControlsNET/blob/main/Documentation/Russian.md)
- [Deutsch :de: :austria: :switzerland:](https://github.com/pediRAM/IPUserControlsNET/blob/main/Documentation/German.md)
- [France :fr:](https://github.com/pediRAM/IPUserControlsNET/blob/main/Documentation/France.md)
- [हिंदी :india:](https://github.com/pediRAM/IPUserControlsNET/blob/main/Documentation/Hindi.md)
- [Türkçe :tr:](https://github.com/pediRAM/IPUserControlsNET/blob/main/Documentation/Turkish.md)
- [فارسی :iran: :afghanistan: :tajikistan:](https://github.com/pediRAM/IPUserControlsNET/blob/main/Documentation/Farsi.md)

*This is a fork of the original [IPUserControls.Wpf](https://github.com/mariugul/IPUserControls) which is written for .NET Framework 4.5.1 by [mariugul](https://github.com/mariugul).* 

<img src="https://raw.githubusercontent.com/pediRAM/IPUserControlsNET/main/Documentation/example-app.jpg" width="400"/> 

## Controls Included:

| **Controls**  | **Description**      | Bindable Property   |
| ------------- |----------------------| ------------------- |
| IpField       | IP Address TextBox   | string or byte[]    |
| IpPort        | IP Port TextBox      | ushort              |
| IpStatus      | IP Connection Status | Connection Status   |

## IpStatus colors:

<table>
<tr>
    <td><img src="https://raw.githubusercontent.com/pediRAM/IPUserControlsNET/main/Documentation/ip_connected.png" width="32"/></td> 
    <td><img src="https://raw.githubusercontent.com/pediRAM/IPUserControlsNET/main/Documentation/ip_connected2.png" width="32"/></td> 
    <td><img src="https://raw.githubusercontent.com/pediRAM/IPUserControlsNET/main/Documentation/ip_connecting.png" width="32"/></td> 
    <td><img src="https://raw.githubusercontent.com/pediRAM/IPUserControlsNET/main/Documentation/ip_connecting2.png" width="32"/></td> 
</tr>
<tr>
    <td>Connected</td><td> Connected2</td><td> Connecting</td><td> Connecting2</td>
</tr>
<tr>
    <td><img src="https://raw.githubusercontent.com/pediRAM/IPUserControlsNET/main/Documentation/ip_disconnected.png" width="32"/></td> 
    <td><img src="https://raw.githubusercontent.com/pediRAM/IPUserControlsNET/main/Documentation/ip_error.png" width="32"/></td> 
    <td><img src="https://raw.githubusercontent.com/pediRAM/IPUserControlsNET/main/Documentation/ip_error2.png" width="32"/></td>
    <td></td>
</tr>
<tr>
    <td> Disconnected</td><td> Error</td><td> Error2</td><td></td>
</tr>
</table>

## IP User Control in Action:
<img src="https://raw.githubusercontent.com/pediRAM/IPUserControlsNET/main/Documentation/usage.gif"/>

## XAML example:

```xml
<Window x:Class="MyProject.MainWindow"
        xmlns="http://schemas.microsoft.com/winfx/2006/xaml/presentation"
        xmlns:x="http://schemas.microsoft.com/winfx/2006/xaml"
        xmlns:ip="clr-namespace:IPUserControlsNET;assembly=IPUserControlsNET">
    <Grid>
        <StackPanel VerticalAlignment="Center">

                <!-- ********** IpField, IpPort and IpStatus ********** -->
                <ip:IpField IpAddress="{Binding IpAddress}"/>
                <ip:IpPort PortNumber="5022"/>
                <ip:IpStatus ConnectionStatus="{Binding ConnectionStatus}"/>
                <!-- *************************************************** -->

        </StackPanel>
    </Grid>
</Window>

```
## Thank you!
   
The whole work and code has been done by **[mariugul](https://github.com/mariugul)** and I want to thank him at this place, because without his great work and efforts, I would not be able to have a WPF library for .NET6, 8 and 9 so fast and easily by just migrating it. Great work! Well done! Thank you **[mariugul](https://github.com/mariugul)** !

This project stands as a testament to the collaborative spirit of the open-source community. I want to extend my deepest gratitude to the many talented individuals and teams whose hard work and dedication have paved the way for this endeavor. Without their pioneering efforts and the generous availability of their tools and libraries, this project would not have been possible.

Their commitment to sharing their work with the world has not only facilitated my contributions but has also enriched the broader development community. Thank you to all who have contributed to the open-source ecosystem, enabling projects like this to flourish.

- [Gnu Image Manipulation Program](https://www.gimp.org/) GPL-3.0 license, copyright by Spencer KIMBALL & Peter MATTIS
- [Greenshot](https://github.com/greenshot/greenshot), a very strightforward screenshot tool, GPL-3.0 license and copyright by [Robin KROM](https://github.com/Lakritzator)
- [Visual Studio 2022 Community](https://visualstudio.microsoft.com/) licensed under [MICROSOFT VISUAL STUDIO COMMUNITY 2022](https://visualstudio.microsoft.com/license-terms/vs2022-ga-community/) copyright by Microsoft
- [Visual Studio Code](https://code.visualstudio.com/) licensed under [MICROSOFT VISUAL STUDIO CODE](https://code.visualstudio.com/license?lang=en)
