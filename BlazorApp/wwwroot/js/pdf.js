function OpenNew(base64string) {
    let pdfWindow = window.open("")
    pdfWindow.document.write(
        "<iframe width='100%' height='100%' src='data:application/pdf;base64, " + base64string + "'></iframe>"
    )
}

function SaveFile(filename, base64string) {
    var link = document.createElement('a');
    link.download = filename;
    link.href = "data:application/octet-stream;base64," + base64string;
    document.body.appendChild(link);
    link.click();
    document.body.removeChild(link);
}
