# IPUserControlsNET

[![.NET](https://img.shields.io/badge/.NET%206-512BD4?logo=dotnet&logoColor=fff)](https://versionsof.net/core/6.0/)
[![.NET](https://img.shields.io/badge/.NET%208-512BD4?logo=dotnet&logoColor=fff)](https://versionsof.net/core/8.0/)
[![.NET](https://img.shields.io/badge/.NET%209-512BD4?logo=dotnet&logoColor=fff)](https://versionsof.net/core/9.0/)
[![License](https://img.shields.io/badge/License-MIT-green.svg)](LICENSE)
[![Release](https://img.shields.io/github/release/pediRAM/IPUserControlsNET.svg?sort=semver)](https://github.com/pediRAM/IPUserControlsNET/releases)
[![NuGet](https://img.shields.io/nuget/v/IPUserControlsNET)](https://www.nuget.org/packages/IPUserControlsNET)

*Этот проект является форком оригинального [IPUserControls.Wpf](https://github.com/mariugul/IPUserControls), который был написан для .NET Framework 4.5.1 автором [mariugul](https://github.com/mariugul).*

<img src="https://raw.githubusercontent.com/pediRAM/IPUserControlsNET/main/Documentation/example-app.jpg" width="400"/>

## Включенные элементы управления:

| **Элементы управления** | **Описание**            | Свойство для привязки |
| ----------------------- |-------------------------| --------------------- |
| IpField                | Текстовое поле IP-адреса | string или byte[]    |
| IpPort                 | Текстовое поле порта IP  | ushort              |
| IpStatus               | Статус подключения IP   | Connection Status   |

## Цвета IpStatus:

<table>
<tr>
    <td><img src="https://raw.githubusercontent.com/pediRAM/IPUserControlsNET/main/Documentation/ip_connected.png" width="32"/></td>
    <td><img src="https://raw.githubusercontent.com/pediRAM/IPUserControlsNET/main/Documentation/ip_connected2.png" width="32"/></td>
    <td><img src="https://raw.githubusercontent.com/pediRAM/IPUserControlsNET/main/Documentation/ip_connecting.png" width="32"/></td>
    <td><img src="https://raw.githubusercontent.com/pediRAM/IPUserControlsNET/main/Documentation/ip_connecting2.png" width="32"/></td>
</tr>
<tr>
    <td>Подключено</td><td>Подключено2</td><td>Подключение</td><td>Подключение2</td>
</tr>
<tr>
    <td><img src="https://raw.githubusercontent.com/pediRAM/IPUserControlsNET/main/Documentation/ip_disconnected.png" width="32"/></td>
    <td><img src="https://raw.githubusercontent.com/pediRAM/IPUserControlsNET/main/Documentation/ip_error.png" width="32"/></td>
    <td><img src="https://raw.githubusercontent.com/pediRAM/IPUserControlsNET/main/Documentation/ip_error2.png" width="32"/></td>
    <td></td>
</tr>
<tr>
    <td>Отключено</td><td>Ошибка</td><td>Ошибка2</td><td></td>
</tr>
</table>

## IP User Control в действии:
<img src="https://raw.githubusercontent.com/pediRAM/IPUserControlsNET/main/Documentation/usage.gif"/>

## Пример XAML:

```xml
<Window x:Class="MyProject.MainWindow"
        xmlns="http://schemas.microsoft.com/winfx/2006/xaml/presentation"
        xmlns:x="http://schemas.microsoft.com/winfx/2006/xaml"
        xmlns:ip="clr-namespace:IPUserControlsNET;assembly=IPUserControlsNET">
    <Grid>
        <StackPanel VerticalAlignment="Center">

                <!-- ********** IpField, IpPort и IpStatus ********** -->
                <ip:IpField IpAddress="{Binding IpAddress}"/>
                <ip:IpPort PortNumber="5022"/>
                <ip:IpStatus ConnectionStatus="{Binding ConnectionStatus}"/>
                <!-- *********************************************** -->

        </StackPanel>
    </Grid>
</Window>

```
## Спасибо!
   
Вся работа и код были выполнены **[mariugul](https://github.com/mariugul)**, и я хочу выразить ему благодарность за это. Без его отличной работы и усилий у меня не было бы WPF-библиотеки для .NET 6, 8 и 9 так быстро и легко, просто благодаря миграции. Отличная работа! Молодец! Спасибо **[mariugul](https://github.com/mariugul)**!

Этот проект является доказательством коллективного духа сообщества с открытым исходным кодом. Я хочу выразить свою искреннюю благодарность многим талантливым людям и командам, чья тяжелая работа и преданность делу проложили путь к этому начинанию. Без их новаторских усилий и щедрого предоставления инструментов и библиотек этот проект был бы невозможен.

Их стремление делиться своей работой с миром не только облегчило мой вклад, но и обогатило более широкое сообщество разработчиков. Спасибо всем, кто внес свой вклад в экосистему открытого исходного кода, позволяя таким проектам, как этот, процветать.

- [Gnu Image Manipulation Program](https://www.gimp.org/) лицензия GPL-3.0, авторские права Spencer KIMBALL & Peter MATTIS
- [Greenshot](https://github.com/greenshot/greenshot), удобный инструмент для создания скриншотов, лицензия GPL-3.0, авторские права [Robin KROM](https://github.com/Lakritzator)
- [Visual Studio 2022 Community](https://visualstudio.microsoft.com/) лицензировано под [MICROSOFT VISUAL STUDIO COMMUNITY 2022](https://visualstudio.microsoft.com/license-terms/vs2022-ga-community/), авторские права принадлежат Microsoft
- [Visual Studio Code](https://code.visualstudio.com/) лицензировано под [MICROSOFT VISUAL STUDIO CODE](https://code.visualstudio.com/license?lang=en)

