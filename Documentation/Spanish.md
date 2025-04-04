# IPUserControlsNET 

[![.NET](https://img.shields.io/badge/.NET%206-512BD4?logo=dotnet&logoColor=fff)](https://versionsof.net/core/6.0/)
[![.NET](https://img.shields.io/badge/.NET%208-512BD4?logo=dotnet&logoColor=fff)](https://versionsof.net/core/8.0/)
[![.NET](https://img.shields.io/badge/.NET%209-512BD4?logo=dotnet&logoColor=fff)](https://versionsof.net/core/9.0/)
[![License](https://img.shields.io/badge/License-MIT-green.svg)](LICENSE)
[![Release](https://img.shields.io/github/release/pediRAM/IPUserControlsNET.svg?sort=semver)](https://github.com/pediRAM/IPUserControlsNET/releases)
[![NuGet](https://img.shields.io/nuget/v/IPUserControlsNET)](https://www.nuget.org/packages/IPUserControlsNET)
<!-- [![.NET](https://img.shields.io/badge/%20E%20U%20👍-0018A8?logo=europeanunion&logoColor=yellow)](https://european-union.europa.eu) -->

*Este es un fork del original [IPUserControls.Wpf](https://github.com/mariugul/IPUserControls), el cual fue escrito para .NET Framework 4.5.1 por [mariugul](https://github.com/mariugul).* 

<img src="https://raw.githubusercontent.com/pediRAM/IPUserControlsNET/main/Documentation/example-app.jpg" width="400"/> 

## Controles incluidos:

| **Controles** | **Descripción**             | Propiedad Vinculable |
|---------------|-----------------------------|-----------------------|
| IpField       | Cuadro de texto de IP       | string o byte[]       |
| IpPort        | Cuadro de texto de Puerto IP| ushort                |
| IpStatus      | Estado de conexión IP       | Connection Status     |

## Colores de IpStatus:

<table>
<tr>
    <td><img src="https://raw.githubusercontent.com/pediRAM/IPUserControlsNET/main/Documentation/ip_connected.png" width="32"/></td> 
    <td><img src="https://raw.githubusercontent.com/pediRAM/IPUserControlsNET/main/Documentation/ip_connected2.png" width="32"/></td> 
    <td><img src="https://raw.githubusercontent.com/pediRAM/IPUserControlsNET/main/Documentation/ip_connecting.png" width="32"/></td> 
    <td><img src="https://raw.githubusercontent.com/pediRAM/IPUserControlsNET/main/Documentation/ip_connecting2.png" width="32"/></td> 
</tr>
<tr>
    <td>Connected</td><td>Connected2</td><td>Connecting</td><td>Connecting2</td>
</tr>
<tr>
    <td><img src="https://raw.githubusercontent.com/pediRAM/IPUserControlsNET/main/Documentation/ip_disconnected.png" width="32"/></td> 
    <td><img src="https://raw.githubusercontent.com/pediRAM/IPUserControlsNET/main/Documentation/ip_error.png" width="32"/></td> 
    <td><img src="https://raw.githubusercontent.com/pediRAM/IPUserControlsNET/main/Documentation/ip_error2.png" width="32"/></td>
    <td></td>
</tr>
<tr>
    <td>Disconnected</td><td>Error</td><td>Error2</td><td></td>
</tr>
</table>

## Control de Usuario IP en acción:
<img src="https://raw.githubusercontent.com/pediRAM/IPUserControlsNET/main/Documentation/usage.gif"/>

## Ejemplo XAML:

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

## ¡Gracias!

Todo el trabajo y código fue realizado por **[mariugul](https://github.com/mariugul)** y quiero agradecerle en este espacio, porque sin su excelente trabajo y esfuerzo, no habría podido tener una biblioteca WPF para .NET6, 8 y 9 de forma tan rápida y sencilla, simplemente migrándola. ¡Gran trabajo! ¡Bien hecho! ¡Gracias **[mariugul](https://github.com/mariugul)**!

Este proyecto representa el espíritu colaborativo de la comunidad de código abierto. Quiero extender mi más sincero agradecimiento a los muchos individuos y equipos talentosos cuyo arduo trabajo y dedicación han allanado el camino para este esfuerzo. Sin sus esfuerzos pioneros y la disponibilidad generosa de sus herramientas y bibliotecas, este proyecto no habría sido posible.

Su compromiso de compartir su trabajo con el mundo no solo ha facilitado mis contribuciones, sino que también ha enriquecido a la comunidad de desarrollo en general. Gracias a todos los que han contribuido al ecosistema de código abierto, permitiendo que proyectos como este prosperen.

- [Gnu Image Manipulation Program](https://www.gimp.org/) licencia GPL-3.0, derechos de autor por Spencer KIMBALL & Peter MATTIS  
- [Greenshot](https://github.com/greenshot/greenshot), una herramienta de capturas de pantalla muy sencilla, licencia GPL-3.0 y derechos de autor por [Robin KROM](https://github.com/Lakritzator)  
- [Visual Studio 2022 Community](https://visualstudio.microsoft.com/) con licencia [MICROSOFT VISUAL STUDIO COMMUNITY 2022](https://visualstudio.microsoft.com/license-terms/vs2022-ga-community/) derechos de autor por Microsoft  
- [Visual Studio Code](https://code.visualstudio.com/) con licencia [MICROSOFT VISUAL STUDIO CODE](https://code.visualstudio.com/license?lang=en)  
