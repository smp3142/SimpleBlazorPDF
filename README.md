# Simple Blazor PDF with iText 7

## How the PDF is made

0) The pdf byte array is prepared in the same way as any other iText project.
    - This example has a separate project called `MakePDF` with a single static class called `MyPdf`
    - It returns a simple generated pdf as a byte array
    - As normal, it needs to be added to the project Dependencies

1) Javascript to save or display the pdf byte array is needed.
    - I usually save it in a folder called `js`
    - I called the file `pdf.js`
    - The Javascript has 2 functions which are called `"SaveFile"` and `"OpenNew"`

2) The `.razor` page needs to have an instance of a JavaScript runtime to dispatch calls.
    - `@inject IJSRuntime js`

3) Add the path to the JavaScript file to the `index.html` file.
    - `<script src="js/pdf.js"></script>`

4) Add C# code to generate the byte array that contains the PDF.

5) Invoke the JavaScript function to save or display the PDF.
