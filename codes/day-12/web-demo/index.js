function butonClicked() {
    //console.log('button clicked');

    //DOM APIs
    var txtFirst =getElement('txtFirstValue');
    var txtSecond = getElement('txtSecondValue');

    var firstValue = getValue(txtFirst);
    var secondValue = getValue(txtSecond);

    var result = add(firstValue, secondValue)
    window.alert("result: " + result)
}
function getElement(elementId){
    return document.getElementById(elementId);
}

function getValue(txtBox){
    return parseInt(txtBox.value);
}

function add(first, second) {
    return (first + second);
}
