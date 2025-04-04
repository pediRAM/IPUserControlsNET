# IPUserControlsNET

[![.NET](https://img.shields.io/badge/.NET%206-512BD4?logo=dotnet&logoColor=fff)](https://versionsof.net/core/6.0/)
[![.NET](https://img.shields.io/badge/.NET%208-512BD4?logo=dotnet&logoColor=fff)](https://versionsof.net/core/8.0/)
[![.NET](https://img.shields.io/badge/.NET%209-512BD4?logo=dotnet&logoColor=fff)](https://versionsof.net/core/9.0/)
[![License](https://img.shields.io/badge/License-MIT-green.svg)](LICENSE)
[![Release](https://img.shields.io/github/release/pediRAM/IPUserControlsNET.svg?sort=semver)](https://github.com/pediRAM/IPUserControlsNET/releases)
[![NuGet](https://img.shields.io/nuget/v/IPUserControlsNET)](https://www.nuget.org/packages/IPUserControlsNET)

*Ceci est un fork de l'original [IPUserControls.Wpf](https://github.com/mariugul/IPUserControls) qui a été écrit pour .NET Framework 4.5.1 par [mariugul](https://github.com/mariugul).* 

<img src="https://raw.githubusercontent.com/pediRAM/IPUserControlsNET/main/Documentation/example-app.jpg" width="400"/> 

## Contrôles inclus :

| **Contrôles**  | **Description**      | Propriété liable   |
| ------------- |----------------------| ------------------- |
| IpField       | Champ de texte d'adresse IP   | string ou byte[]    |
| IpPort        | Champ de texte de port IP      | ushort              |
| IpStatus      | État de connexion IP | Connection Status   |

## Couleurs de IpStatus :

<table>
<tr>
    <td><img src="https://raw.githubusercontent.com/pediRAM/IPUserControlsNET/main/Documentation/ip_connected.png" width="32"/></td> 
    <td><img src="https://raw.githubusercontent.com/pediRAM/IPUserControlsNET/main/Documentation/ip_connected2.png" width="32"/></td> 
    <td><img src="https://raw.githubusercontent.com/pediRAM/IPUserControlsNET/main/Documentation/ip_connecting.png" width="32"/></td> 
    <td><img src="https://raw.githubusercontent.com/pediRAM/IPUserControlsNET/main/Documentation/ip_connecting2.png" width="32"/></td> 
</tr>
<tr>
    <td>Connecté</td><td> Connecté2</td><td> En connexion</td><td> En connexion2</td>
</tr>
<tr>
    <td><img src="https://raw.githubusercontent.com/pediRAM/IPUserControlsNET/main/Documentation/ip_disconnected.png" width="32"/></td> 
    <td><img src="https://raw.githubusercontent.com/pediRAM/IPUserControlsNET/main/Documentation/ip_error.png" width="32"/></td> 
    <td><img src="https://raw.githubusercontent.com/pediRAM/IPUserControlsNET/main/Documentation/ip_error2.png" width="32"/></td>
    <td></td>
</tr>
<tr>
    <td> Déconnecté</td><td> Erreur</td><td> Erreur2</td><td></td>
</tr>
</table>

## IP User Control en action :
<img src="https://raw.githubusercontent.com/pediRAM/IPUserControlsNET/main/Documentation/usage.gif"/>

## Exemple XAML :

```xml
<Window x:Class="MyProject.MainWindow"
        xmlns="http://schemas.microsoft.com/winfx/2006/xaml/presentation"
        xmlns:x="http://schemas.microsoft.com/winfx/2006/xaml"
        xmlns:ip="clr-namespace:IPUserControlsNET;assembly=IPUserControlsNET">
    <Grid>
        <StackPanel VerticalAlignment="Center">

                <!-- ********** IpField, IpPort et IpStatus ********** -->
                <ip:IpField IpAddress="{Binding IpAddress}"/>
                <ip:IpPort PortNumber="5022"/>
                <ip:IpStatus ConnectionStatus="{Binding ConnectionStatus}"/>
                <!-- *************************************************** -->

        </StackPanel>
    </Grid>
</Window>

```
## Merci !
   
Tout le travail et le code ont été réalisés par **[mariugul](https://github.com/mariugul)** et je tiens à le remercier ici, car sans son excellent travail et ses efforts, je n'aurais pas pu obtenir une bibliothèque WPF pour .NET6, 8 et 9 aussi rapidement et facilement en la migrant simplement. Excellent travail ! Bravo ! Merci **[mariugul](https://github.com/mariugul)** !

Ce projet est une preuve de l'esprit collaboratif de la communauté open-source. Je tiens à exprimer ma plus profonde gratitude aux nombreux individus et équipes talentueux dont le travail acharné et le dévouement ont permis de mener à bien cette initiative. Sans leurs efforts pionniers et la mise à disposition généreuse de leurs outils et bibliothèques, ce projet n'aurait pas été possible.

Leur engagement à partager leur travail avec le monde a non seulement facilité ma contribution, mais a également enrichi la communauté du développement en général. Merci à tous ceux qui ont contribué à l'écosystème open-source, permettant ainsi à des projets comme celui-ci de prospérer.

- [Gnu Image Manipulation Program](https://www.gimp.org/) sous licence GPL-3.0, copyright par Spencer KIMBALL & Peter MATTIS
- [Greenshot](https://github.com/greenshot/greenshot), un outil de capture d'écran très simple, sous licence GPL-3.0 et copyright par [Robin KROM](https://github.com/Lakritzator)
- [Visual Studio 2022 Community](https://visualstudio.microsoft.com/) sous licence [MICROSOFT VISUAL STUDIO COMMUNITY 2022](https://visualstudio.microsoft.com/license-terms/vs2022-ga-community/) copyright par Microsoft
- [Visual Studio Code](https://code.visualstudio.com/) sous licence [MICROSOFT VISUAL STUDIO CODE](https://code.visualstudio.com/license?lang=en)

