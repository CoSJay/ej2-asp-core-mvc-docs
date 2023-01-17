---
layout: post
title: Instantiate the PDF Viewer component ##Platform_Name## Pdfviewer Component
description: Learn how to dynamically instantiate the PDF Viewer component in Syncfusion ##Platform_Name## Pdfviewer component of Syncfusion Essential JS 2 and more.
platform: ej2-asp-core-mvc
control: Instantiate the PDF Viewer component dynamically and load PDF documents
publishingplatform: ##Platform_Name##
documentation: ug
---

# Instantiate the PDF Viewer component dynamically

To instantiate a PDF Viewer component dynamically and load PDF documents in Syncfusion PDF Viewer, use the following steps:

In your HTML file, create a div element that will act as a container for the PDF Viewer component, and use the jQuery $.ajax method to make an AJAX request to your server and retrieve a PDF document. Once the document is retrieved, use the PDF Viewer API to load the document into the PDF Viewer component.

Use the serviceUrl property of the PDF Viewer instance to set the URL of a PDF document you want to load.

```html

<div style="width:100%;height:600px">
    <button id="loadPDF">Load PDF Viewer</button>
    <div id="pdfViewer" style="height: 100%;width: 100%;"></div>
</div>

<script>
    document.getElementById("loadPDF").addEventListener('click', function () {
      $.ajax({
          url: "https://ej2services.syncfusion.com/production/web-services/api/pdfviewer",
            type: "GET",
            success: function(data){
                var viewer = new ej.pdfviewer.PdfViewer({
                    documentPath : "PDF_Succinctly.pdf",
                    serviceUrl : "https://ej2services.syncfusion.com/production/web-services/api/pdfviewer",            
                });
                viewer.appendTo("#pdfViewer");
            }
        });
    });
</script>

```

In your controller, create an action method that returns a PDF document as a FileResult.

Sample [https://www.syncfusion.com/downloads/support/directtrac/general/ze/InitiatePDFInButtonClick-256355185.zip](https://www.syncfusion.com/downloads/support/directtrac/general/ze/InitiatePDFInButtonClick-256355185.zip)

Also, refer to the official documentation of syncfusion pdf viewer for more information[refer to this link](https://ej2.syncfusion.com/aspnetcore/documentation/pdfviewer/getting-started).

N>Ensure the provided document path and output text are saved at your application level.