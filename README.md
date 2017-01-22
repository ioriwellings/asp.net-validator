# asp.net-validator
Input Validation System and Validation Controls for ASP.Net
This project contains two parts:

ServerSideValidation: Easy implemented, flexible string validator for C# projects.

ValidationControl: Web form textbox controls which wrap ServerSideValidation implementation and support JQuery Validation.

ServerSideValidation

String checker for server side validation.

Providing checkers:

Requirement
Min - max length
Equal to
Pattern
The built-in patterns:

Alphanumeric
Letter only
Digits only
Float
Date
Phone
Email
URL
URL friendly
No HTML tag
Free for all
Custom
Supports custom defined patterns.

Supports custom error messages.

Supports input key.

Supports multi language.

ValidationControl

Custom textbox control library for validation. Supports all the features that ServerSideValidation and Textbox have. Supports a wrapper control which can merge and inject javascripts.

Requires JQuery and JQuery Validation for javascript validation.

Usage

For detailed usage try ValidationControl.FormTest project.

Aspx page:

<vc:JsRegisterer ID="JsRegisterer1" runat="server">
  <Content>
    <table>
      <tr>
        <td><vc:ValidationLetter ID="ValidationLetter1" Key="LetterField" Required="True" runat="server"/></td>
      </tr>
      <tr>
        <td><vc:ValidationDigit ID="ValidationDigit1" Key="DigitField" runat="server"/></td>
      </tr>
      <tr>
        <td><vc:ValidationAlphanumeric ID="ValidationAlphanumeric1" Key="AlphanumericField" runat="server"/></td>
      </tr>
      <!--etc...-->
    </table>      
  </Content>
</vc:JsRegisterer>

Code behind validation:

foreach (Control control in JsRegisterer1.Controls.OfType<ValidationBase>())
{
    if (control != null)
    {
        var field = control as ValidationBase;
        if (!field.ValidateField())
        {
            //Do something with using field.Error and field.Key
        }
    }
}
