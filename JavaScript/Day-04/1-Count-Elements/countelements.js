function showResult() {
  var inputTagName = document.getElementById("tagName").value;
  var tagNames = document.getElementsByTagName(inputTagName);

  var inputClassName = document.getElementById("className").value;
  var classNames = document.getElementsByClassName(inputClassName);

  var inputIdName = document.getElementById("idName").value;
  var idNames = document.getElementById(inputIdName);

  var inputNameAttr = document.getElementById("nameAttr").value;
  var nameAttrs = document.getElementsByName(inputNameAttr);

  var output = document.getElementById("output");
  output.innerText =
    "Number of \nElement (" +
    inputTagName +
    "): " +
    tagNames.length +
    "\nClass (" +
    inputClassName +
    "): " +
    classNames.length +
    "\nId (" +
    inputIdName +
    "): " +
    Boolean(idNames) +
    "\n Name Attribute (" +
    inputNameAttr +
    "): " +
    nameAttrs.length;
}
