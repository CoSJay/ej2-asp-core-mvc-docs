---
layout: post
title: Ribbon Items in ##Platform_Name## Ribbon Control | Syncfusion
description: Learn here all about Items in Syncfusion ##Platform_Name## Ribbon control of Syncfusion Essential JS 2 and more.
platform: ej2-asp-core-mvc
control: Ribbon
publishingplatform: ##Platform_Name##
documentation: ug
---

# Ribbon Items

Ribbon renders various built-in items based on the item [type](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Ribbon.RibbonItem.html#Syncfusion_EJ2_Ribbon_RibbonItem_Type) property. By default, the type property is set as `Button` which renders the Button.

## Built-in items

You can render the built-in Ribbon items by using the `<e-ribbon-item>` tag helper, to specify the [type](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Ribbon.RibbonItem.html#Syncfusion_EJ2_Ribbon_RibbonItem_Type) property.

The following table explains the built-in items and their actions.

| Built-in Ribbon Items | Actions |
|------------------------|---------|
| Button | Renders button as ribbon item.|
| CheckBox | Renders checkbox as ribbon item.|
| DropDown | Renders dropdownbutton as ribbon item.|
| SplitButton | Renders splitbutton as ribbon item.|
| ComboBox | Renders combobox as ribbon item.|
| ColorPicker | Renders color picker as ribbon item.|

### Button items

You can render the built-in button Ribbon item by setting the [type](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Ribbon.RibbonItem.html#Syncfusion_EJ2_Ribbon_RibbonItem_Type) property as `Button`. You can also customize the button item using the [RibbonButtonSettings](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Ribbon.RibbonButtonSettings.html), which provides options such as `iconCss`, `content`, `isToggle` and more.
#### Toggle button

The [isToggle](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Ribbon.RibbonButtonSettings.html#Syncfusion_EJ2_Ribbon_RibbonButtonSettings_IsToggle) property can be used to define whether the button act as a toggle button or not. By default, the value is `false`.

{% tabs %}
{% highlight c# tabtitle="Index.cshtml" %}

@using Syncfusion.EJ2.Ribbon
@using Syncfusion.EJ2.Navigations

<ejs-ribbon id="ribbon">
    <e-ribbon-tabs>
        <e-ribbon-tab header="Home">
            <e-ribbon-groups>
                <e-ribbon-group header="Clipboard">
                    <e-ribbon-collections>
                        <e-ribbon-collection>
                            <e-ribbon-items>
                                <e-ribbon-item type=Button>
                                    <e-ribbon-buttonsettings iconCss="e-icons e-cut" content="Cut" isToggle=true></e-ribbon-buttonsettings>
                                </e-ribbon-item>
                            </e-ribbon-items>
                        </e-ribbon-collection>
                    </e-ribbon-collections>
                </e-ribbon-group>
            </e-ribbon-groups>
        </e-ribbon-tab>
    </e-ribbon-tabs>
</ejs-ribbon>

{% endhighlight %}
{% endtabs %}

### Checkbox items

You can render the built-in checkBox Ribbon item by setting the [type](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Ribbon.RibbonItem.html#Syncfusion_EJ2_Ribbon_RibbonItem_Type) property to `CheckBox`. You can also customize the checkBox item using the [RibbonCheckBoxSettings](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Ribbon.RibbonCheckBoxSettings.html), which provides options such as `labelPosition`, `label`, `checked` and more.

#### Checkbox state

You can use the [checked](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Ribbon.RibbonCheckBoxSettings.html#Syncfusion_EJ2_Ribbon_RibbonCheckBoxSettings_Checked) property to handle the checked or unchecked state. By default, the value is `false`.

{% tabs %}
{% highlight c# tabtitle="Index.cshtml" %}

@using Syncfusion.EJ2.Ribbon
@using Syncfusion.EJ2.Navigations

<ejs-ribbon id="ribbon">
    <e-ribbon-tabs>
        <e-ribbon-tab header="Home">
            <e-ribbon-groups>
                <e-ribbon-group header="View">
                    <e-ribbon-collections>
                        <e-ribbon-collection>
                            <e-ribbon-items>
                                <e-ribbon-item type=CheckBox>
                                    <e-ribbon-checkboxsettings checked=true label="Ruler"></e-ribbon-checkboxsettings>
                                </e-ribbon-item>
                            </e-ribbon-items>
                        </e-ribbon-collection>
                    </e-ribbon-collections>
                </e-ribbon-group>
            </e-ribbon-groups>
        </e-ribbon-tab>
    </e-ribbon-tabs>
</ejs-ribbon>

{% endhighlight %}
{% endtabs %}

#### Defining label

You can use the [label](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Ribbon.RibbonCheckBoxSettings.html#Syncfusion_EJ2_Ribbon_RibbonCheckBoxSettings_Label) property to add a caption for the CheckBox. The label position can be set `Before` or `After`, by using the [labelPosition](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Ribbon.RibbonCheckBoxSettings.html#Syncfusion_EJ2_Ribbon_RibbonCheckBoxSettings_LabelPosition) property. By default, the labelPosition is `After`.

{% tabs %}
{% highlight c# tabtitle="Index.cshtml" %}

@using Syncfusion.EJ2.Ribbon
@using Syncfusion.EJ2.Buttons
@using Syncfusion.EJ2.Navigations

<ejs-ribbon id="ribbon">
    <e-ribbon-tabs>
        <e-ribbon-tab header="Home">
            <e-ribbon-groups>
                <e-ribbon-group header="View">
                    <e-ribbon-collections>
                        <e-ribbon-collection>
                            <e-ribbon-items>
                                <e-ribbon-item type=CheckBox>
                                    <e-ribbon-checkboxsettings checked=true label="Ruler" labelPosition=LabelPosition.Before></e-ribbon-checkboxsettings>
                                </e-ribbon-item>
                            </e-ribbon-items>
                        </e-ribbon-collection>
                    </e-ribbon-collections>
                </e-ribbon-group>
            </e-ribbon-groups>
        </e-ribbon-tab>
    </e-ribbon-tabs>
</ejs-ribbon>

{% endhighlight %}
{% endtabs %}

### DropDown button items

You can render the built-in dropDown Ribbon item by setting the [type](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Ribbon.RibbonItem.html#Syncfusion_EJ2_Ribbon_RibbonItem_Type) property to `DropDown`. You can also customize the dropDown item through [RibbonDropDownSettings](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Ribbon.RibbonDropDownSettings.html), which provides options such as `iconCss`, `content`, `target` and more.

#### Target

The [target](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Ribbon.RibbonDropDownSettings.html#Syncfusion_EJ2_Ribbon_RibbonDropDownSettings_Target) property specifies the element selector to be displayed in the DropDownButton popup.

{% tabs %}
{% highlight c# tabtitle="Index.cshtml" %}

@using Syncfusion.EJ2.Ribbon
@using Syncfusion.EJ2.Navigations

@{
    string[] pictureOptions = new string[] { "This device", "Stock Images", "Online Images" };
}

<ejs-ribbon id="ribbon">
    <e-ribbon-tabs>
        <e-ribbon-tab header="Home">
            <e-ribbon-groups>
                <e-ribbon-group header="Illustrations">
                    <e-ribbon-collections>
                        <e-ribbon-collection>
                            <e-ribbon-items>
                                <e-ribbon-item type=DropDown>
                                    <e-ribbon-dropdownsettings iconCss="e-icons e-image" content="Pictures" target="#pictureList"></e-ribbon-dropdownsettings>
                                </e-ribbon-item>
                            </e-ribbon-items>
                        </e-ribbon-collection>
                    </e-ribbon-collections>
                </e-ribbon-group>
            </e-ribbon-groups>
        </e-ribbon-tab>
    </e-ribbon-tabs>
</ejs-ribbon>
<ejs-listview id="pictureList" showHeader=true headerTitle="Insert Picture From" dataSource=pictureOptions></ejs-listview>

{% endhighlight %}
{% endtabs %}

### Split button items

You can render the built-in splitButton Ribbon item by setting the [type](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Ribbon.RibbonItem.html#Syncfusion_EJ2_Ribbon_RibbonItem_Type) property to `SplitButton` you can render a splitButton item. You can also customize the SplitButton item through [RibbonSplitButtonSettings](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Ribbon.RibbonSplitButtonSettings.html#properties), which provides options such as `IconCss`, `Items`, `Target` and more.

#### Target

The [target](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Ribbon.RibbonSplitButtonSettings.html#Syncfusion_EJ2_Ribbon_RibbonSplitButtonSettings_Target) property specifies the element selector to be displayed in the SplitButton popup.

{% tabs %}
{% highlight c# tabtitle="Index.cshtml" %}

@using Syncfusion.EJ2.Ribbon
@using Syncfusion.EJ2.Navigations

@{
    string[] pictureOptions = new string[] { "This device", "Stock Images", "Online Images" };
}

<ejs-ribbon id="ribbon">
    <e-ribbon-tabs>
        <e-ribbon-tab header="Home">
            <e-ribbon-groups>
                <e-ribbon-group header="Illustrations">
                    <e-ribbon-collections>
                        <e-ribbon-collection>
                            <e-ribbon-items>
                                <e-ribbon-item type=SplitButton>
                                    <e-ribbon-splitbuttonsettings iconCss="e-icons e-image" content="Pictures" target="#pictureList"></e-ribbon-splitbuttonsettings>
                                </e-ribbon-item>
                            </e-ribbon-items>
                        </e-ribbon-collection>
                    </e-ribbon-collections>
                </e-ribbon-group>
            </e-ribbon-groups>
        </e-ribbon-tab>
    </e-ribbon-tabs>
</ejs-ribbon>
<ejs-listview id="pictureList" showHeader=true headerTitle="Insert Picture From" dataSource=pictureOptions></ejs-listview>

{% endhighlight %}
{% endtabs %}

### Combobox items

You can render the built-in comboBox Ribbon item by setting the [type](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Ribbon.RibbonItem.html#Syncfusion_EJ2_Ribbon_RibbonItem_Type) property to `ComboBox` you can render a comboBox item. You can also customize the ComboBox item through [RibbonComboBoxSettings](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Ribbon.RibbonComboBoxSettings.html), which provides options such as `AllowFiltering`, `AutoFill`, `Index`, `SortOrder` and more.

#### Filtering

You can use the [allowFiltering](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Ribbon.RibbonComboBoxSettings.html#Syncfusion_EJ2_Ribbon_RibbonComboBoxSettings_AllowFiltering) property to filter the data items. The filtering operation is initiated automatically, as soon as you start typing characters. If no match is found, the value of the `noRecordsTemplate` property will be displayed. By default, the value is `false`.

{% tabs %}
{% highlight c# tabtitle="Index.cshtml" %}

@using Syncfusion.EJ2.Ribbon
@using Syncfusion.EJ2.Navigations

@{
    List<string> fontStyle = new List<string>() { "Algerian", "Arial", "Calibri", "Cambria", "Cambria Math", "Courier New", "Candara", "Georgia" };
}

<ejs-ribbon id="ribbon">
    <e-ribbon-tabs>
        <e-ribbon-tab header="Home">
            <e-ribbon-groups>
                <e-ribbon-group header="Font">
                    <e-ribbon-collections>
                        <e-ribbon-collection>
                            <e-ribbon-items>
                                <e-ribbon-item type=ComboBox>
                                    <e-ribbon-comboboxsettings dataSource=fontStyle allowFiltering=true></e-ribbon-comboboxsettings>
                                </e-ribbon-item>
                            </e-ribbon-items>
                        </e-ribbon-collection>
                    </e-ribbon-collections>
                </e-ribbon-group>
            </e-ribbon-groups>
        </e-ribbon-tab>
    </e-ribbon-tabs>
</ejs-ribbon>

{% endhighlight %}
{% endtabs %}

#### Index

You can use the [index](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Ribbon.RibbonComboBoxSettings.html#Syncfusion_EJ2_Ribbon_RibbonComboBoxSettings_Index) property to get or set the selected item in the combobox.

{% tabs %}
{% highlight c# tabtitle="Index.cshtml" %}

@using Syncfusion.EJ2.Ribbon
@using Syncfusion.EJ2.Navigations

@{
    List<string> fontStyle = new List<string>() { "Algerian", "Arial", "Calibri", "Cambria", "Cambria Math", "Courier New", "Candara", "Georgia" };
}

<ejs-ribbon id="ribbon">
    <e-ribbon-tabs>
        <e-ribbon-tab header="Home">
            <e-ribbon-groups>
                <e-ribbon-group header="Font">
                    <e-ribbon-collections>
                        <e-ribbon-collection>
                            <e-ribbon-items>
                                <e-ribbon-item type=ComboBox>
                                    <e-ribbon-comboboxsettings dataSource=fontStyle index=3></e-ribbon-comboboxsettings>
                                </e-ribbon-item>
                            </e-ribbon-items>
                        </e-ribbon-collection>
                    </e-ribbon-collections>
                </e-ribbon-group>
            </e-ribbon-groups>
        </e-ribbon-tab>
    </e-ribbon-tabs>
</ejs-ribbon>

{% endhighlight %}
{% endtabs %}

#### SortOrder

You can use the [sortOrder](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Ribbon.RibbonComboBoxSettings.html#Syncfusion_EJ2_Ribbon_RibbonComboBoxSettings_SortOrder) property to specify the order in which the DataSource should be sorted.

<table>
  <tr>
    <td>`None`</td>
    <td>The data source is not sorted.</td>
  </tr>
  <tr>
    <td>`Ascending`</td>
    <td>The data source is sorted in ascending order.</td>
  </tr>
  <tr>
    <td>`Descending`</td>
    <td>The data source is sorted in descending order.</td>
  </tr>
</table>

{% tabs %}
{% highlight c# tabtitle="Index.cshtml" %}

@using Syncfusion.EJ2.Ribbon
@using Syncfusion.EJ2.Navigations

@{
    List<string> fontStyle = new List<string>() { "Algerian", "Arial", "Calibri", "Cambria", "Cambria Math", "Courier New", "Candara", "Georgia" };
}

<ejs-ribbon id="ribbon">
    <e-ribbon-tabs>
        <e-ribbon-tab header="Home">
            <e-ribbon-groups>
                <e-ribbon-group header="Font">
                    <e-ribbon-collections>
                        <e-ribbon-collection>
                            <e-ribbon-items>
                                <e-ribbon-item type=ComboBox>
                                    <e-ribbon-comboboxsettings dataSource=fontStyle sortOrder=SortOrder.Descending></e-ribbon-comboboxsettings>
                                </e-ribbon-item>
                            </e-ribbon-items>
                        </e-ribbon-collection>
                    </e-ribbon-collections>
                </e-ribbon-group>
            </e-ribbon-groups>
        </e-ribbon-tab>
    </e-ribbon-tabs>
</ejs-ribbon>

{% endhighlight %}
{% endtabs %}

### Colorpicker items

You can render the built-in colorPicker Ribbon item by setting the [type](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Ribbon.RibbonItem.html#Syncfusion_EJ2_Ribbon_RibbonItem_Type) property to `ColorPicker`. You can also customize the colorPicker item through [RibbonColorPickerSettings](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Ribbon.RibbonColorPickerSettings.html), which provides options such as `Value`, `Columns`, `ShowButtons` and more.

#### Value


You can use the [value](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Ribbon.RibbonColorPickerSettings.html#Syncfusion_EJ2_Ribbon_RibbonColorPickerSettings_Value) property to specify the color value. The value should be specified as Hex code.

{% tabs %}
{% highlight c# tabtitle="Index.cshtml" %}

@using Syncfusion.EJ2.Ribbon
@using Syncfusion.EJ2.Inputs
@using Syncfusion.EJ2.Navigations

<ejs-ribbon id="ribbon">
    <e-ribbon-tabs>
        <e-ribbon-tab header="Home">
            <e-ribbon-groups>
                <e-ribbon-group header="Font">
                    <e-ribbon-collections>
                        <e-ribbon-collection>
                            <e-ribbon-items>
                                <e-ribbon-item type=ColorPicker>
                                    <e-ribbon-colorpickersettings value="035a"></e-ribbon-colorpickersettings>
                                </e-ribbon-item>
                            </e-ribbon-items>
                        </e-ribbon-collection>
                    </e-ribbon-collections>
                </e-ribbon-group>
            </e-ribbon-groups>
        </e-ribbon-tab>
    </e-ribbon-tabs>
</ejs-ribbon>

{% endhighlight %}
{% endtabs %}

## Custom items

You can customize the ribbon items with non-built-in items or HTML content by setting the [type](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Ribbon.RibbonItem.html#Syncfusion_EJ2_Ribbon_RibbonItem_Type) property to `Template`. This provides an option to customize the ribbon items with greater flexibility.

{% tabs %}
{% highlight c# tabtitle="Index.cshtml" %}

@using Syncfusion.EJ2.Ribbon
@using Syncfusion.EJ2.Navigations

<ejs-ribbon id="ribbon">
    <e-ribbon-tabs>
        <e-ribbon-tab header="Home">
            <e-ribbon-groups>
                <e-ribbon-group header="Font">
                    <e-ribbon-collections>
                        <e-ribbon-collection>
                            <e-ribbon-items>
                                <e-ribbon-item type=Template itemTemplate='<span class="ribbonTemplate ${activeSize}"><span class="e-icons e-video"></span><span class="text">Video</span></span>'>
                                </e-ribbon-item>
                            </e-ribbon-items>
                        </e-ribbon-collection>
                    </e-ribbon-collections>
                </e-ribbon-group>
            </e-ribbon-groups>
        </e-ribbon-tab>
    </e-ribbon-tabs>
</ejs-ribbon>

<style>

    .ribbonTemplate {
        display: flex;
        align-items: center;
        justify-content: center;
        cursor: pointer;
    }

        .ribbonTemplate.Large {
            flex-direction: column;
        }

            .ribbonTemplate.Large .e-icons {
                font-size: 35px;
            }

        .ribbonTemplate.Medium .e-icons,
        .ribbonTemplate.Small .e-icons {
            font-size: 20px;
            margin: 15px 5px;
        }

        .ribbonTemplate.Small .text {
            display: none;
        }

</style>

{% endhighlight %}
{% endtabs %}

![ASP.NET Core Ribbon Control with Custom Ribbon items](./images/customRibbonItem.png)

## Items display Mode

You can use the [displayOptions](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Ribbon.RibbonItem.html#Syncfusion_EJ2_Ribbon_RibbonItem_DisplayOptions) property to display the items in the Ribbon.

<table>
  <tr>
    <td>`Auto`</td>
    <td>The items are displayed in all layouts based on the ribbon's overflow state.</td>
  </tr>
  <tr>
    <td>`Classic`</td>
    <td>The items are displayed only in the classic layout group.</td>
  </tr>
  <tr>
    <td>`Simplified`</td>
    <td>The items are displayed only in the simplified layout group.</td>
  </tr>
  <tr>
    <td>`Overflow`</td>
    <td>The items are displayed only in the overflow popup.</td>
  </tr>
</table>

### Display items in Classic only

To diplay the items only in the classic layout group, set the mode as `DisplayMode.Classic` in the [displayOptions](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Ribbon.RibbonItem.html#Syncfusion_EJ2_Ribbon_RibbonItem_DisplayOptions) property.

{% tabs %}
{% highlight c# tabtitle="Index.cshtml" %}

@using Syncfusion.EJ2.Ribbon
@using Syncfusion.EJ2.Navigations

<ejs-ribbon id="ribbon">
    <e-ribbon-tabs>
        <e-ribbon-tab header="Home">
            <e-ribbon-groups>
                <e-ribbon-group header="Clipboard">
                    <e-ribbon-collections>
                        <e-ribbon-collection>
                            <e-ribbon-items>
                                <e-ribbon-item displayOptions=@(Syncfusion.EJ2.Ribbon.DisplayMode.Classic) type=Button>
                                    <e-ribbon-buttonsettings iconCss="e-icons e-cut" content="Cut" isToggle=true></e-ribbon-buttonsettings>
                                </e-ribbon-item>
                            </e-ribbon-items>
                        </e-ribbon-collection>
                    </e-ribbon-collections>
                </e-ribbon-group>
            </e-ribbon-groups>
        </e-ribbon-tab>
    </e-ribbon-tabs>
</ejs-ribbon>

{% endhighlight %}
{% endtabs %}

### Display items in Simplified only

To diplay the items only in the simplified layout group, set the mode as `DisplayMode.Simplified` in the [displayOptions](https://help.syncfusion.com/cr/aspnetmvc-core/Syncfusion.EJ2.Ribbon.RibbonItem.html#Syncfusion_EJ2_Ribbon_RibbonItem_DisplayOptions) property.

{% tabs %}
{% highlight c# tabtitle="Index.cshtml" %}

@using Syncfusion.EJ2.Ribbon
@using Syncfusion.EJ2.Navigations

<ejs-ribbon id="ribbon">
    <e-ribbon-tabs>
        <e-ribbon-tab header="Home">
            <e-ribbon-groups>
                <e-ribbon-group header="Clipboard">
                    <e-ribbon-collections>
                        <e-ribbon-collection>
                            <e-ribbon-items>
                                <e-ribbon-item displayOptions=@(Syncfusion.EJ2.Ribbon.DisplayMode.Simplified) type=Button>
                                    <e-ribbon-buttonsettings iconCss="e-icons e-cut" content="Cut" isToggle=true></e-ribbon-buttonsettings>
                                </e-ribbon-item>
                            </e-ribbon-items>
                        </e-ribbon-collection>
                    </e-ribbon-collections>
                </e-ribbon-group>
            </e-ribbon-groups>
        </e-ribbon-tab>
    </e-ribbon-tabs>
</ejs-ribbon>

{% endhighlight %}
{% endtabs %}

### Display items in Overflow popup only

To diplay the items only in the overflow, set the mode as `DisplayMode.Overflow` in the [displayOptions](https://help.syncfusion.com/cr/aspnetmvc-core/Syncfusion.EJ2.Ribbon.RibbonItem.html#Syncfusion_EJ2_Ribbon_RibbonItem_DisplayOptions) property.

{% tabs %}
{% highlight c# tabtitle="Index.cshtml" %}

@using Syncfusion.EJ2.Ribbon
@using Syncfusion.EJ2.Navigations

<ejs-ribbon id="ribbon">
    <e-ribbon-tabs>
        <e-ribbon-tab header="Home">
            <e-ribbon-groups>
                <e-ribbon-group header="Clipboard">
                    <e-ribbon-collections>
                        <e-ribbon-collection>
                            <e-ribbon-items>
                                <e-ribbon-item displayOptions=@(Syncfusion.EJ2.Ribbon.DisplayMode.Overflow) type=Button>
                                    <e-ribbon-buttonsettings iconCss="e-icons e-cut" content="Cut" isToggle=true></e-ribbon-buttonsettings>
                                </e-ribbon-item>
                            </e-ribbon-items>
                        </e-ribbon-collection>
                    </e-ribbon-collections>
                </e-ribbon-group>
            </e-ribbon-groups>
        </e-ribbon-tab>
    </e-ribbon-tabs>
</ejs-ribbon>

{% endhighlight %}
{% endtabs %}

## Enable or disable items

The [disabled](https://help.syncfusion.com/cr/aspnetcore-js2/Syncfusion.EJ2.Ribbon.RibbonItem.html#Syncfusion_EJ2_Ribbon_RibbonItem_Disabled) property can be used to disable an item. The item will be disabled and prevents the user interaction when set to `true`. By default the value is `false`.

{% tabs %}
{% highlight c# tabtitle="Index.cshtml" %}

@using Syncfusion.EJ2.Ribbon
@using Syncfusion.EJ2.Navigations

<ejs-ribbon id="ribbon">
    <e-ribbon-tabs>
        <e-ribbon-tab header="Home">
            <e-ribbon-groups>
                <e-ribbon-group header="Clipboard">
                    <e-ribbon-collections>
                        <e-ribbon-collection>
                            <e-ribbon-items>
                                <e-ribbon-item disabled=true type=Button>
                                    <e-ribbon-buttonsettings iconCss="e-icons e-cut" content="Cut" isToggle=true></e-ribbon-buttonsettings>
                                </e-ribbon-item>
                                <e-ribbon-item disabled=true type=CheckBox>
                                    <e-ribbon-checkboxsettings label= "Ruler", checked=true></e-ribbon-checkboxsettings>
                                </e-ribbon-item>
                                <e-ribbon-item disabled=true type=DropDown>
                                    <e-ribbon-dropdownsettings content= "Table", iconCss= "e-icons e-table"></e-ribbon-dropdownsettings>
                                </e-ribbon-item>
                            </e-ribbon-items>
                        </e-ribbon-collection>
                    </e-ribbon-collections>
                </e-ribbon-group>
            </e-ribbon-groups>
        </e-ribbon-tab>
    </e-ribbon-tabs>
</ejs-ribbon>

{% endhighlight %}
{% endtabs %}