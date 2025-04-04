# IPUserControls.NET .NET6, .NET8, .NET9
*This is the fork of [.NET Framework 4.5.1 version written by mariugul](https://github.com/mariugul/IPUserControls)*

This repository provides **WPF controls** like: **IP Address**, **Text Box**, **IP Port Text Box** and **IP Connection Status Icon** for following Frameworks: **.NET6, .NET8, .NET9** which you can **download** from [Nuget.org](https://www.nuget.org/packages/IPUserControls.Modern).
  
[![License](https://img.shields.io/badge/License-MIT-green.svg)](LICENSE)
[![Release](https://img.shields.io/github/release/pediRAM/IPUserControls.Modern.svg?sort=semver)](https://github.com/pediRAM/IPUserControls.Modern/releases)
[![NuGet](https://img.shields.io/nuget/v/IPUserControls.Modern)](https://www.nuget.org/packages/IPUserControls.Modern)
 
<img src="Doc/usage.gif"/>
 
## Controls Included
| **Controls**  | **Description**      | Bindable Property   |
| ------------- |----------------------| ------------------- | 
| IpField       | IP Address TextBox   | string or byte[]    |
| IpPort        | IP Port TextBox      | ushort              |
| IpStatus      | IP Connection Status | Connection Status   |

 
 
## Usage
1. Install the [IPUserControls](https://www.nuget.org/packages/IPUserControls.Wpf/1.1.0#) Nuget package
2. Add this to your _SomeView.xaml_ namespace
    ```xaml
    xmlns:ip="clr-namespace:IPUserControls;assembly=IPUserControls.Wpf"
    ```
3. Access the IP controls by typing either or all of the commands
   
   ```xaml
    <ip:IpField />
    ```
   <img src="Doc/ipField.png"/> <br><br>
    
    ```xaml
    <ip:IpPort />
    ```
    <img src="Doc/ipPort.png"/>  <br><br>
 
    ```xaml
    <ip:IpStatus />
    ```
    <img src="Doc/ipStatus.png"/>  
    
4. Setting up the View in XAML shown below. I use Prism and an MVVM design. For an example on how to bind to the ViewModel, see the [Prototyping Prism](https://github.com/mariugul/IPUserControls/tree/main/Prototyping%20Prism) project in this repository. It does basic binding to get the IP, Port and set connection status.

<img src="Doc/xamlSetUp.gif"/>
   
