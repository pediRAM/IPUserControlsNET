# IPUserControlsNET

[![.NET](https://img.shields.io/badge/.NET%206-512BD4?logo=dotnet&logoColor=fff)](https://versionsof.net/core/6.0/)
[![.NET](https://img.shields.io/badge/.NET%208-512BD4?logo=dotnet&logoColor=fff)](https://versionsof.net/core/8.0/)
[![.NET](https://img.shields.io/badge/.NET%209-512BD4?logo=dotnet&logoColor=fff)](https://versionsof.net/core/9.0/)
[![License](https://img.shields.io/badge/License-MIT-green.svg)](LICENSE)
[![Release](https://img.shields.io/github/release/pediRAM/IPUserControlsNET.svg?sort=semver)](https://github.com/pediRAM/IPUserControlsNET/releases)
[![NuGet](https://img.shields.io/nuget/v/IPUserControlsNET)](https://www.nuget.org/packages/IPUserControlsNET)

*این یک شاخه از نسخه اصلی [IPUserControls.Wpf](https://github.com/mariugul/IPUserControls) است که برای .NET Framework 4.5.1 توسط [mariugul](https://github.com/mariugul) نوشته شده است.*

<img src="https://raw.githubusercontent.com/pediRAM/IPUserControlsNET/main/Documentation/example-app.jpg" width="400"/>

## کنترل‌های موجود:

| **کنترل‌ها**  | **توضیحات**          | ویژگی قابل اتصال   |
| ------------- |----------------------| ------------------- |
| IpField       | تکست‌باکس آدرس IP    | رشته یا byte[]     |
| IpPort        | تکست‌باکس پورت IP    | ushort             |
| IpStatus      | وضعیت اتصال IP      | Connection Status   |

## رنگ‌های IpStatus:

<table>
<tr>
    <td><img src="https://raw.githubusercontent.com/pediRAM/IPUserControlsNET/main/Documentation/ip_connected.png" width="32"/></td>
    <td><img src="https://raw.githubusercontent.com/pediRAM/IPUserControlsNET/main/Documentation/ip_connected2.png" width="32"/></td>
    <td><img src="https://raw.githubusercontent.com/pediRAM/IPUserControlsNET/main/Documentation/ip_connecting.png" width="32"/></td>
    <td><img src="https://raw.githubusercontent.com/pediRAM/IPUserControlsNET/main/Documentation/ip_connecting2.png" width="32"/></td>
</tr>
<tr>
    <td>متصل</td><td>متصل2</td><td>در حال اتصال</td><td>در حال اتصال2</td>
</tr>
<tr>
    <td><img src="https://raw.githubusercontent.com/pediRAM/IPUserControlsNET/main/Documentation/ip_disconnected.png" width="32"/></td>
    <td><img src="https://raw.githubusercontent.com/pediRAM/IPUserControlsNET/main/Documentation/ip_error.png" width="32"/></td>
    <td><img src="https://raw.githubusercontent.com/pediRAM/IPUserControlsNET/main/Documentation/ip_error2.png" width="32"/></td>
    <td></td>
</tr>
<tr>
    <td>قطع شده</td><td>خطا</td><td>خطا2</td><td></td>
</tr>
</table>

## کنترل کاربری IP در عمل:
<img src="https://raw.githubusercontent.com/pediRAM/IPUserControlsNET/main/Documentation/usage.gif"/>

## نمونه XAML:

```xml
<Window x:Class="MyProject.MainWindow"
        xmlns="http://schemas.microsoft.com/winfx/2006/xaml/presentation"
        xmlns:x="http://schemas.microsoft.com/winfx/2006/xaml"
        xmlns:ip="clr-namespace:IPUserControlsNET;assembly=IPUserControlsNET">
    <Grid>
        <StackPanel VerticalAlignment="Center">

                <!-- ********** IpField, IpPort و IpStatus ********** -->
                <ip:IpField IpAddress="{Binding IpAddress}"/>
                <ip:IpPort PortNumber="5022"/>
                <ip:IpStatus ConnectionStatus="{Binding ConnectionStatus}"/>
                <!-- *************************************************** -->

        </StackPanel>
    </Grid>
</Window>
```

## سپاسگزاری!

تمامی کارها و کدنویسی توسط **[mariugul](https://github.com/mariugul)** انجام شده است. من از او در اینجا تشکر می‌کنم، زیرا بدون کار بزرگ و تلاش‌های او، من قادر به داشتن یک کتابخانه WPF برای .NET6، 8 و 9 به این سرعت و سادگی تنها با مهاجرت آن نبودم. کار عالی! آفرین! متشکرم **[mariugul](https://github.com/mariugul)**!

این پروژه به عنوان نمونه‌ای از روحیه همکاری در جامعه متن‌باز ایستاده است. من می‌خواهم قدردانی عمیق خود را از بسیاری از افراد و تیم‌های با استعداد که تلاش سخت‌کوشانه و تعهدشان راه را برای این تلاش هموار کرده است، ابراز کنم. بدون تلاش‌های پیشگامانه آن‌ها و دسترسی سخاوتمندانه به ابزارها و کتابخانه‌هایشان، این پروژه امکان‌پذیر نبود.

تعهد آن‌ها به اشتراک‌گذاری کارشان با جهان نه تنها مشارکت من را تسهیل کرده بلکه جامعه توسعه‌دهندگان را نیز غنی‌تر کرده است. از همه کسانی که در اکوسیستم متن‌باز مشارکت کرده‌اند و پروژه‌هایی مانند این را ممکن کرده‌اند، سپاسگزارم.

- [Gnu Image Manipulation Program](https://www.gimp.org/) تحت مجوز GPL-3.0، کپی‌رایت توسط اسپنسر کیمبال و پیتر ماتیس
- [Greenshot](https://github.com/greenshot/greenshot)، ابزاری بسیار ساده برای گرفتن اسکرین‌شات، تحت مجوز GPL-3.0 و کپی‌رایت توسط [Robin KROM](https://github.com/Lakritzator)
- [Visual Studio 2022 Community](https://visualstudio.microsoft.com/) تحت مجوز [MICROSOFT VISUAL STUDIO COMMUNITY 2022](https://visualstudio.microsoft.com/license-terms/vs2022-ga-community/) کپی‌رایت مایکروسافت
- [Visual Studio Code](https://code.visualstudio.com/) تحت مجوز [MICROSOFT VISUAL STUDIO CODE](https://code.visualstudio.com/license?lang=en)

