
using System.ComponentModel;

namespace IPUserControlsNET.MAUI;

public partial class IpField : ContentView
{
    public IpField()
    {
        InitializeComponent();
        Loaded += (s, e) => UpdateOctetsOrIgnore();
        BindingContext = this;
    }


    #region Bindable Properties
    public static readonly BindableProperty Octet0Property = BindableProperty.Create(nameof(Octet0), typeof(string), typeof(IpField), "0");
    public static readonly BindableProperty Octet1Property = BindableProperty.Create(nameof(Octet1), typeof(string), typeof(IpField), "0");
    public static readonly BindableProperty Octet2Property = BindableProperty.Create(nameof(Octet2), typeof(string), typeof(IpField), "0");
    public static readonly BindableProperty Octet3Property = BindableProperty.Create(nameof(Octet3), typeof(string), typeof(IpField), "0");

    public static readonly BindableProperty IpAddressProperty = BindableProperty.Create(nameof(IpAddress), typeof(string), typeof(IpField), "0.0.0.0");
    public static readonly BindableProperty TextColorProperty = BindableProperty.Create(nameof(TextColor), typeof(Brush), typeof(IpField), Brush.Black);
    #endregion Bindable Properties

    public Brush TextColor
    {
        get => (Brush)GetValue(TextColorProperty);
        set => SetValue(TextColorProperty, value);
    }

    public string Octet0
    {
        get => (string)GetValue(Octet0Property);
        set
        {
            SetValue(Octet0Property, value.NormalizeOctet());
            UpdateIpAddress();
        }
    }



    public string Octet1
    {
        get => (string)GetValue(Octet1Property);
        set
        {
            SetValue(Octet1Property, value.NormalizeOctet());
            UpdateIpAddress();
        }
    }

    public string Octet2
    {
        get => (string)GetValue(Octet2Property);
        set
        {
            SetValue(Octet2Property, value.NormalizeOctet());
            UpdateIpAddress();
        }
    }

    public string Octet3
    {
        get => (string)GetValue(Octet3Property);
        set
        {
            SetValue(Octet3Property, value.NormalizeOctet());
            UpdateIpAddress();
        }
    }

    public string IpAddress
    {
        get => (string)GetValue(IpAddressProperty);
        set => UpdateOctetsOrIgnore(value);
    }

    private void UpdateIpAddress()
    {
        string ipAddress = $"{Octet0}.{Octet1}.{Octet2}.{Octet3}";
        SetValue(IpAddressProperty, ipAddress);
    }

    private void UpdateOctetsOrIgnore(string validIPv4String)
    {
        string[] octets = validIPv4String.Split('.');
        if (octets.Length == 4)
        {
            Octet0 = octets[0];
            Octet1 = octets[1];
            Octet2 = octets[2];
            Octet3 = octets[3];
        }
    }

    private void UpdateOctetsOrIgnore() => UpdateOctetsOrIgnore(IpAddress);

    private void OnFocused(object sender, FocusEventArgs e)
    {
        Entry entry = ((Entry)sender);
        entry.Text = entry.Text.NormalizeOctet();
    }

    private void OnUnfocused(object sender, FocusEventArgs e)
    {
        Entry entry = ((Entry)sender);
        if (entry.Text != null && entry.Text.Length == 0) entry.Text = "0";
    }
}