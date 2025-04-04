# IPUserControlsNET

[![.NET](https://img.shields.io/badge/.NET%206-512BD4?logo=dotnet&logoColor=fff)](https://versionsof.net/core/6.0/)  
[![.NET](https://img.shields.io/badge/.NET%208-512BD4?logo=dotnet&logoColor=fff)](https://versionsof.net/core/8.0/)  
[![.NET](https://img.shields.io/badge/.NET%209-512BD4?logo=dotnet&logoColor=fff)](https://versionsof.net/core/9.0/)  
[![License](https://img.shields.io/badge/License-MIT-green.svg)](LICENSE)  
[![Release](https://img.shields.io/github/release/pediRAM/IPUserControlsNET.svg?sort=semver)](https://github.com/pediRAM/IPUserControlsNET/releases)  
[![NuGet](https://img.shields.io/nuget/v/IPUserControlsNET)](https://www.nuget.org/packages/IPUserControlsNET)  
<!-- [![.NET](https://img.shields.io/badge/%20E%20U%20👍-0018A8?logo=europeanunion&logoColor=yellow)](https://european-union.europa.eu) -->

*Bu, [mariugul](https://github.com/mariugul) tarafından .NET Framework 4.5.1 için yazılmış olan orijinal [IPUserControls.Wpf](https://github.com/mariugul/IPUserControls) projesinin bir çatalıdır (fork).*  

<img src="https://raw.githubusercontent.com/pediRAM/IPUserControlsNET/main/Documentation/example-app.jpg" width="400"/>  

## Dahil Edilen Kontroller:

| **Controls**  | **Açıklama**                | Bağlanabilir Özellik   |
| ------------- |-----------------------------| ---------------------- |
| IpField       | IP Adresi Metin Kutusu       | string veya byte[]     |
| IpPort        | IP Port Metin Kutusu         | ushort                 |
| IpStatus      | IP Bağlantı Durumu           | Connection Status      |

## IpStatus renkleri:

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

## IP Kullanıcı Denetimi Uygulamada:
<img src="https://raw.githubusercontent.com/pediRAM/IPUserControlsNET/main/Documentation/usage.gif"/>

## XAML örneği:

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

## Teşekkürler!

Tüm çalışma ve kod **[mariugul](https://github.com/mariugul)** tarafından yapılmıştır. Bu noktada kendisine içten teşekkür etmek istiyorum çünkü onun harika çalışması ve çabası olmasaydı, bu projeyi sadece göç ettirerek .NET6, 8 ve 9 için bu kadar hızlı ve kolay şekilde bir WPF kütüphanesine dönüştüremezdim. Harika iş! Eline sağlık! Teşekkürler **[mariugul](https://github.com/mariugul)**!

Bu proje, açık kaynak topluluğunun iş birliği ruhunun bir kanıtıdır. Bu girişime zemin hazırlayan çok sayıda yetenekli bireye ve ekibe en derin şükranlarımı sunmak istiyorum. Onların öncü çabaları ve araçlarını/kütüphanelerini cömertçe erişilebilir kılmaları olmadan bu proje mümkün olamazdı.

Yaptıkları çalışmaları dünya ile paylaşma konusundaki kararlılıkları, yalnızca kendi katkılarımı kolaylaştırmakla kalmadı, aynı zamanda daha geniş yazılım geliştirme topluluğunu da zenginleştirdi. Açık kaynak ekosistemine katkıda bulunan herkese teşekkürler — bu tür projelerin gelişmesini mümkün kıldığınız için.

- [Gnu Image Manipulation Program](https://www.gimp.org/), GPL-3.0 lisansı, telif hakkı Spencer KIMBALL & Peter MATTIS  
- [Greenshot](https://github.com/greenshot/greenshot), oldukça basit bir ekran görüntüsü aracı, GPL-3.0 lisansı, telif hakkı [Robin KROM](https://github.com/Lakritzator)  
- [Visual Studio 2022 Community](https://visualstudio.microsoft.com/), [MICROSOFT VISUAL STUDIO COMMUNITY 2022](https://visualstudio.microsoft.com/license-terms/vs2022-ga-community/) lisansıyla, telif hakkı Microsoft  
- [Visual Studio Code](https://code.visualstudio.com/), [MICROSOFT VISUAL STUDIO CODE](https://code.visualstudio.com/license?lang=en) lisansı ile  
