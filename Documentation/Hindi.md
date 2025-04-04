# IPUserControlsNET

[![.NET](https://img.shields.io/badge/.NET%206-512BD4?logo=dotnet&logoColor=fff)](https://versionsof.net/core/6.0/)
[![.NET](https://img.shields.io/badge/.NET%208-512BD4?logo=dotnet&logoColor=fff)](https://versionsof.net/core/8.0/)
[![.NET](https://img.shields.io/badge/.NET%209-512BD4?logo=dotnet&logoColor=fff)](https://versionsof.net/core/9.0/)
[![License](https://img.shields.io/badge/License-MIT-green.svg)](LICENSE)
[![Release](https://img.shields.io/github/release/pediRAM/IPUserControlsNET.svg?sort=semver)](https://github.com/pediRAM/IPUserControlsNET/releases)
[![NuGet](https://img.shields.io/nuget/v/IPUserControlsNET)](https://www.nuget.org/packages/IPUserControlsNET)

*यह [IPUserControls.Wpf](https://github.com/mariugul/IPUserControls) का एक फोर्क है, जिसे [mariugul](https://github.com/mariugul) द्वारा .NET Framework 4.5.1 के लिए लिखा गया था।*

<img src="https://raw.githubusercontent.com/pediRAM/IPUserControlsNET/main/Documentation/example-app.jpg" width="400"/>

## शामिल नियंत्रण (Controls):

| **नियंत्रण (Controls)** | **विवरण (Description)** | बाइंडेबल प्रॉपर्टी (Bindable Property) |
| ------------- |----------------------| ------------------- |
| IpField       | IP पता टेक्स्टबॉक्स | string या byte[]    |
| IpPort        | IP पोर्ट टेक्स्टबॉक्स | ushort              |
| IpStatus      | IP कनेक्शन स्थिति   | Connection Status   |

## IpStatus रंग:

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

## IP उपयोगकर्ता नियंत्रण (User Control) का उपयोग:
<img src="https://raw.githubusercontent.com/pediRAM/IPUserControlsNET/main/Documentation/usage.gif"/>

## XAML उदाहरण:

```xml
<Window x:Class="MyProject.MainWindow"
        xmlns="http://schemas.microsoft.com/winfx/2006/xaml/presentation"
        xmlns:x="http://schemas.microsoft.com/winfx/2006/xaml"
        xmlns:ip="clr-namespace:IPUserControlsNET;assembly=IPUserControlsNET">
    <Grid>
        <StackPanel VerticalAlignment="Center">

                <!-- ********** IpField, IpPort और IpStatus ********** -->
                <ip:IpField IpAddress="{Binding IpAddress}"/>
                <ip:IpPort PortNumber="5022"/>
                <ip:IpStatus ConnectionStatus="{Binding ConnectionStatus}"/>
                <!-- *************************************************** -->

        </StackPanel>
    </Grid>
</Window>
```
## धन्यवाद!

पूरा काम और कोड **[mariugul](https://github.com/mariugul)** द्वारा किया गया है और मैं इस अवसर पर उन्हें धन्यवाद देना चाहता हूँ। उनके उत्कृष्ट कार्य और प्रयासों के बिना, मैं इतने आसानी से .NET6, 8 और 9 के लिए WPF लाइब्रेरी को माइग्रेट नहीं कर पाता। शानदार कार्य! बहुत बढ़िया! धन्यवाद **[mariugul](https://github.com/mariugul)**!

यह प्रोजेक्ट ओपन-सोर्स समुदाय की सहयोगात्मक भावना का प्रतीक है। मैं उन सभी प्रतिभाशाली व्यक्तियों और टीमों के प्रति अपनी गहरी कृतज्ञता व्यक्त करना चाहता हूँ, जिनके कठिन परिश्रम और समर्पण ने इस प्रयास को संभव बनाया।

उनके द्वारा उपलब्ध कराए गए टूल और लाइब्रेरी ने न केवल मेरे योगदान को सक्षम बनाया बल्कि व्यापक डेवलपर समुदाय को भी समृद्ध किया है। उन सभी का धन्यवाद, जिन्होंने ओपन-सोर्स इकोसिस्टम में योगदान दिया, जिससे ऐसे प्रोजेक्ट फली-फूले।

- [Gnu Image Manipulation Program](https://www.gimp.org/) GPL-3.0 लाइसेंस, कॉपीराइट Spencer KIMBALL & Peter MATTIS
- [Greenshot](https://github.com/greenshot/greenshot), एक बहुत ही सरल स्क्रीनशॉट टूल, GPL-3.0 लाइसेंस, कॉपीराइट [Robin KROM](https://github.com/Lakritzator)
- [Visual Studio 2022 Community](https://visualstudio.microsoft.com/) [MICROSOFT VISUAL STUDIO COMMUNITY 2022](https://visualstudio.microsoft.com/license-terms/vs2022-ga-community/) के तहत लाइसेंस प्राप्त, कॉपीराइट Microsoft
- [Visual Studio Code](https://code.visualstudio.com/) [MICROSOFT VISUAL STUDIO CODE](https://code.visualstudio.com/license?lang=en) के तहत लाइसेंस प्राप्त

