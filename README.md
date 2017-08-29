# GenericTagHelper

## Installation

From Package-Manager <strong>Install-Package GenericTaghelper </strong>
<br/>
From .NET-CLI <strong>dotnet add package GenericTaghelper </strong>

## Introduction

GenericTagHelper offer you general html widget generated by Asp.Net Core TagHelper.
<br/>
GenericFormTagHelper help you to building html code without repeating.


## How To Use It

Add <strong>@addTagHelper GenericTagHelper.Form.*,GenericTagHelper</strong> to your import _ViewImports.cshtml
<br/>
<strong>FormTagHelper</strong>
And add generic and form-model attributes to your form

```html
<form generic form-model="@Model"></form>

```
form-model attribute is your binding model or viewmodel

<strong>TableTagHelper</strong>
Add generic attribute in your table to active generic table taghelper
<br/>
For example 

```html
<table generic
       class="panel panel-primary"
       table-heads='["Id","Name","Gender"]' // your table head list 
       items="@Model.CustomerList" // your item list
       item-per-page="10" // show your numbers of per-page
       panel-title="Customer" // Set you table panel title
    ></table>
```

<br/>

### For Examlpe...
Your model or viewModel looks like this 

```C#
public class Customer
{
    public int Id { get; set; }

    public string Name { get; set; }

    public string Email { get; set; }

    public string Password { get; set; }

    public DateTime RegisteredDate { get; set; }
}
```

And when you load your model with generic form taghelper the html code will be as same as this code:
```html

<form asp-action="CreateForm">
    <div class="form-group">
        <label asp-for="Id"></label>
        <input asp-for="Id" class="form-control" />
        <span asp-validation-for="Id"></span>
    </div>
    <div class="form-group">
        <label asp-for="Name"></label>
        <input asp-for="Name" class="form-control" />
        <span asp-validation-for="Name"></span>
    </div>
    <div class="form-group">
        <label asp-for="Email"></label>
        <input asp-for="Email" class="form-control" />
        <span asp-validation-for="Email"></span>
    </div>
    <div class="form-group">
        <label asp-for="Password"></label>
        <input asp-for="Password" class="form-control" />
        <span asp-validation-for="Password"></span>
    </div>
    <div class="form-group">
        <label asp-for="RegisteredDate"></label>
        <input asp-for="RegisteredDate" class="form-control" />
        <span asp-validation-for="RegisteredDate"></span>
    </div>
   
    <button type="submit" class="btn btn-primary">Submit</button>
    <a asp-action="Index" class="btn btn-default">Cancel</a>
</form>
```
## Customizable Attributes

You can customize your form tag's attributes by Json format string

## For Example
<h4><strong>Add Class to your tag</strong></h4>
You want to change class of your Name label's content
And you can add json string to class-label in your generic form tag

```html
<form generic form-model="@Model"
              class-label='{
                name:"form-control"
              }'
</form>
```

The key is your model property's name and is <string>case-insenstive</strong>.
<br/>
The value is your class attribute's content
<br/>

<h4><strong>Add Attributes to your tag</strong></h4>
You want to add attribute of your Name label
And you can add json string to attributes-label in your generic form tag

<br/>

```html
<form generic form-model="@Model"
              attributes-label='{
                name:{
                    custom_attr:"this is custom attribute"
                }
              }'
</form>
```

For other customizale attributes,please see this table...

<table>
    <thead>
        <tr>
            <th>Attributes</th>
            <th>Description</th>
        </tr>
    </thead>
    <tbody>
        <tr>
            <td>
                <strong>class-form-group</strong>
            </td>
            <td>Customize your form group's div tag class attribute.</td>
        </tr>
         <tr>
            <td>
                <strong>class-label</strong>
            </td>
            <td>Customize your label tag class attribute.</td>
        </tr>
         <tr>
            <td>
                <strong>class-input</strong>
            </td>
            <td>Customize your input tag class attribute.</td>
        </tr>
         <tr>
            <td>
                <strong>class-span</strong>
            </td>
            <td>Customize your validation message span tag class attribute.</em></td>
        </tr>
         <tr>
            <td>
                <strong>attributes-form-group</strong>
            </td>
            <td>Customize your form group's div tag attribute.</td>
        </tr>
         <tr>
            <td>
                <strong>attributes-label</strong>
            </td>
            <td>Customize your label tag attribute.</td>
        </tr>
         <tr>
            <td>
                <strong>attributes-input</strong>
            </td>
            <td>Customize your input tag attribute.</td>
        </tr>
         <tr>
            <td>
                <strong>attributes-span</strong>
            </td>
            <td>Customize your span tag attribute.</td>
        </tr>
    </tbody>
</table>

<hr/>
<h4><strong>Other Customizable Attributes</strong></h4>

<table>
    <thead>
       <tr>
            <th>Attributes</th>
            <th>Description</th>
        </tr>
    </thead>
    <tbody>
        <tr>
            <td>
                <strong>form-title</strong>
            </td>
            <td>Customize your form title by html string.<strong>the default is <em>Form</em></strong></td>
        </tr>
        <tr>
            <td>
                <strong>form-title-class</strong>
            </td>
            <td>Customize your form title's class.<strong>the default is <em>Empty</em></strong></td>
        </tr>
        <tr>
            <td>
                <strong>all-class-form-group</strong>
            </td>
            <td>Add your custom class to your form-group's tag.<strong>the default is <em>form-group</em></strong></td>
        </tr>
        <tr>
            <td>
                <strong>all-class-label</strong>
            </td>
            <td>Add your custom class to your label tag.<strong>the default is <em>Empty</em></strong></td>
        </tr>
        <tr>
            <td>
                <strong>all-class-input</strong>
            </td>
            <td>Add your custom class to your input tag.<strong>the default is <em>form-group</em></strong></td>
        </tr>
        <tr>
            <td>
                <strong>all-class-span</strong>
            </td>
            <td>Add your custom class to your span tag.<strong>the default is <em>Empty</em></strong></td>
        </tr>
        <tr>
            <td>
                <strong>submit-btn-class</strong>
            </td>
            <td>Add your custom class to your submit button tag.<strong>the default is <em>btn btn-primary</em></strong></td>
        </tr>
        <tr>
            <td>
                <strong>submit-btn-contant</strong>
            </td>
            <td>Add your custom class to your submit button tag.<strong>the default is <em>Submit</em></strong></td>
        </tr>
        <tr>
            <td>
                <strong>cancel-btn-class</strong>
            </td>
            <td>Add your custom class to your cancel button tag.<strong>the default is <em>btn btn-efault</em></strong></td>
        </tr>
        <tr>
            <td>
                <strong>cabcel-btn-contant</strong>
            </td>
            <td>Add your contant to your cancel button tag.<strong>the default is <em>Cancel</em></strong></td>
        </tr>
        <tr>
            <td>
                <strong>cancel-link-return-action</strong>
            </td>
            <td>Add action to your link with cancel tag.<strong>the default is <em>Empty</em></strong></td>
        </tr>
        <tr>
            <td>
                <strong>cancel-link-return-controller</strong>
            </td>
            <td>Add controller to your link with cancel tag.<strong>the default is <em>Empty</em></strong></td>
        </tr>
    </tbody>
</table>

## Complex Type Property Supported

If you want to use complex type (Not default complex type String or DateTime)with generic form taghelper,you must put your complex type properties under the primary type properties
<br/>
### For Example
Your model or viewmodel must be like this...

``` c#
        public int Id { get; set; }

        public string Name { get; set; }

        public string Email { get; set; }

        public bool IsAdmin { get; set; }

        public string Password { get; set; }

        public DateTime RegisteredDate { get; set; }

/*-----------------complex properties type under the primary type properties---------------------------*/
        public Address Addresses { get; set; }
```

### Load Your Complex Type Model

With version 1.1.0, You don't need to set up any attribute with you form,It will automatic load you primary type properties nad complex type properties.
<br/>
<strong>Notice</strong> Do not supported nested complex type model or view model.

## Enum Type Property Supported

The enum type is suppored in form.
so if your model enum is like this...

```c#
public enum Level
{
    Bronze,
    Silver,
    Gold,
    Patinum
}

public class Customer{
    public Level Level { get; set; }
}
```

And your form will generate html like this...

```html
<div class="form-group">
        <label for="Levels">Levels</label>
        <select class="form-control valid" data-val="true" 
        data-val-required="The Levels field is required." id="Levels" 
        name="Levels" aria-required="true" aria-invalid="false" 
        aria-describedby="Levels-error">
        
        <option value="0">Bronze</option>
        <option value="1">Silver</option>
        <option value="2">Gold</option>
        <option value="3">Patinum</option>
        
        </select>
        <span class="field-validation-valid" data-valmsg-for="Levels" data-valmsg-replace="true"></span>
    </div>
```

<hr/>

and more.... will update as soon as possible
