# HTML Label for Xamarin.Forms apps

[![Build status](https://dev.azure.com/edsnider/htmllabel/_apis/build/status/htmllabel-CI)](https://dev.azure.com/edsnider/htmllabel/_build/latest?definitionId=4)
[![MyGet](https://img.shields.io/myget/edsnider/vpre/XamForms.HtmlLabel.svg?label=myget)](https://www.myget.org/feed/edsnider/package/nuget/XamForms.HtmlLabel)
[![NuGet](https://img.shields.io/nuget/v/XamForms.HtmlLabel.svg?label=nuget)](https://www.nuget.org/packages/XamForms.HtmlLabel)

Easily render HTML in your Xamarin.Forms apps.

**Note:** This control is intended for basic text formatting (e.g., bold, italic, hyperlinks, etc.). It is not intended for rendering complex HTML or webpages - use the `WebView` for that.

## Dependency

- Xamarin.Forms >= 3.0.0.446417

## Supported platforms

HtmlLabel is supported on the following Xamarin.Forms platforms:

- iOS  
- Android

## Usage

You use `HtmlLabel` just like any other control on a Xamarin.Forms `ContentPage`. 

The value of the `Text` property will be rendered as HTML using the platform's native text formatting approach.

### XAML example

```xaml
<ContentPage 
    ...  
    xmlns:controls="clr-namespace:XamForms.HtmlLabel;assembly=XamForms.HtmlLabel">

    <StackLayout VerticalOptions="CenterAndExpand" HorizontalOptions="Center" WidthRequest="250">
        
        <Entry Text="" Placeholder="Username" />
        <Entry Text="" Placeholder="Password" />
        <Button Text="Sign in" BackgroundColor="Purple" TextColor="White" />
        
        <controls:HtmlLabel Text="Upon sign in you agree to our &lt;a href='http://www.infernored.com'&gt;Terms of Service&lt;/a&gt; and &lt;a href='http://www.infernored.com'&gt;Privacy Policy&lt;/a&gt;." />

        <!-- Or, with data binding -->
        <controls:HtmlLabel Text="{Binding SignInAgreementText}" />

    </StackLayout>

</ContentPage>
```

When using this control in XAML it is recommended you use [XAMLC](https://docs.microsoft.com/en-us/xamarin/xamarin-forms/xaml/xamlc).

### C# example
```csharp
var signInLinks = new HtmlLabel
{
    Text = @"Upon sign in you agree to our <a href=""http://www.infernored.com"">Terms of Service</a> and <a href=""http://www.infernored.com"">Privacy Policy</a>."
};
```

## License

Licensed under MIT. See [License file](https://github.com/edsnider/htmllabel/blob/master/LICENSE)
