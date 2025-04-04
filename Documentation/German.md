# IPUserControlsNET 

[![.NET](https://img.shields.io/badge/.NET%206-512BD4?logo=dotnet&logoColor=fff)](https://versionsof.net/core/6.0/)
[![.NET](https://img.shields.io/badge/.NET%208-512BD4?logo=dotnet&logoColor=fff)](https://versionsof.net/core/8.0/)
[![.NET](https://img.shields.io/badge/.NET%209-512BD4?logo=dotnet&logoColor=fff)](https://versionsof.net/core/9.0/)
[![License](https://img.shields.io/badge/License-MIT-green.svg)](LICENSE)
[![Release](https://img.shields.io/github/release/pediRAM/IPUserControlsNET.svg?sort=semver)](https://github.com/pediRAM/IPUserControlsNET/releases)
[![NuGet](https://img.shields.io/nuget/v/IPUserControlsNET)](https://www.nuget.org/packages/IPUserControlsNET)
<!-- [![.NET](https://img.shields.io/badge/%20E%20U%20👍-0018A8?logo=europeanunion&logoColor=yellow)](https://european-union.europa.eu) -->

*Dies ist ein Fork des ursprünglichen [IPUserControls.Wpf](https://github.com/mariugul/IPUserControls), der für .NET Framework 4.5.1 von [mariugul](https://github.com/mariugul) geschrieben wurde.* 

<img src="Documentation/example-app.jpg" width="400"/> 

## Enthaltene Steuerelemente:

| **Steuerelemente**  | **Beschreibung**      | Bindbare Eigenschaft   |
| ------------- |----------------------| ------------------- |
| IpField       | IP-Adresse TextBox   | string oder byte[]    |
| IpPort        | IP-Port TextBox      | ushort              |
| IpStatus      | IP-Verbindungsstatus | Verbindung Status   |

## IpStatus Farben:

<table>
<tr>
    <td><img src="https://raw.githubusercontent.com/pediRAM/IPUserControlsNET/main/Documentation/ip_connected.png" width="32"/></td> 
    <td><img src="https://raw.githubusercontent.com/pediRAM/IPUserControlsNET/main/Documentation/ip_connected2.png" width="32"/></td> 
    <td><img src="https://raw.githubusercontent.com/pediRAM/IPUserControlsNET/main/Documentation/ip_connecting.png" width="32"/></td> 
    <td><img src="https://raw.githubusercontent.com/pediRAM/IPUserControlsNET/main/Documentation/ip_connecting2.png" width="32"/></td> 
</tr>
<tr>
    <td>Verbunden</td><td> Verbunden2</td><td> Verbindet</td><td> Verbindet2</td>
</tr>
<tr>
    <td><img src="https://raw.githubusercontent.com/pediRAM/IPUserControlsNET/main/Documentation/ip_disconnected.png" width="32"/></td> 
    <td><img src="https://raw.githubusercontent.com/pediRAM/IPUserControlsNET/main/Documentation/ip_error.png" width="32"/></td> 
    <td><img src="https://raw.githubusercontent.com/pediRAM/IPUserControlsNET/main/Documentation/ip_error2.png" width="32"/></td>
    <td></td>
</tr>
<tr>
    <td> Getrennt</td><td> Fehler</td><td> Fehler2</td><td></td>
</tr>
</table>

## IP Benutzersteuerung in Aktion:
<img src="https://raw.githubusercontent.com/pediRAM/IPUserControlsNET/main/Documentation/usage.gif"/>

## XAML Beispiel:

```xml
<Window x:Class="MyProject.MainWindow"
        xmlns="http://schemas.microsoft.com/winfx/2006/xaml/presentation"
        xmlns:x="http://schemas.microsoft.com/winfx/2006/xaml"
        xmlns:ip="clr-namespace:IPUserControlsNET;assembly=IPUserControlsNET">
    <Grid>
        <StackPanel VerticalAlignment="Center">

                <!-- ********** IpField, IpPort und IpStatus ********** -->
                <ip:IpField IpAddress="{Binding IpAddress}"/>
                <ip:IpPort PortNumber="5022"/>
                <ip:IpStatus ConnectionStatus="{Binding ConnectionStatus}"/>
                <!-- *************************************************** -->

        </StackPanel>
    </Grid>
</Window>

```
## Danke!

Die gesamte Arbeit und der Code wurden von **[mariugul](https://github.com/mariugul)** erledigt, und ich möchte ihm an dieser Stelle danken, denn ohne seine großartige Arbeit und Anstrengungen wäre es mir nicht so schnell und einfach möglich gewesen, eine WPF-Bibliothek für .NET6, 8 und 9 einfach zu migrieren. Großartige Arbeit! Sehr gut gemacht! Vielen Dank **[mariugul](https://github.com/mariugul)**!

Dieses Projekt steht als Zeugnis des kollaborativen Geistes der Open-Source-Community. Ich möchte meinen tiefsten Dank an die vielen talentierten Einzelpersonen und Teams aussprechen, deren harte Arbeit und Engagement den Weg für dieses Vorhaben geebnet haben. Ohne ihre pionierhaften Bemühungen und die großzügige Bereitstellung ihrer Tools und Bibliotheken wäre dieses Projekt nicht möglich gewesen.

Ihr Engagement, ihre Arbeit mit der Welt zu teilen, hat nicht nur meine Beiträge erleichtert, sondern auch die breitere Entwicklergemeinschaft bereichert. Vielen Dank an alle, die zur Open-Source-Community beigetragen haben, die es Projekten wie diesem ermöglicht hat, zu gedeihen.

- [Gnu Image Manipulation Program](https://www.gimp.org/) GPL-3.0 Lizenz, Copyright von Spencer KIMBALL & Peter MATTIS
- [Greenshot](https://github.com/greenshot/greenshot), ein sehr einfaches Screenshot-Tool, GPL-3.0 Lizenz und Copyright von [Robin KROM](https://github.com/Lakritzator)
- [Visual Studio 2022 Community](https://visualstudio.microsoft.com/) lizenziert unter [MICROSOFT VISUAL STUDIO COMMUNITY 2022](https://visualstudio.microsoft.com/license-terms/vs2022-ga-community/) Copyright von Microsoft
- [Visual Studio Code](https://code.visualstudio.com/) lizenziert unter [MICROSOFT VISUAL STUDIO CODE](https://code.visualstudio.com/license?lang=en)

---

Let me know if you need any further changes!