var resultArray = [];

function butonClicked() {
    //console.log('button clicked');

    //DOM APIs
    var txtFirst = getElement('txtFirstValue');
    var txtSecond = getElement('txtSecondValue');

    var firstValue = getValue(txtFirst);
    var secondValue = getValue(txtSecond);

    var radios = document.getElementsByName('calculationRadios');
    var checkedRadio = null;
    for (var index = 0; index < radios.length; index++) {
        var radio = radios[index];
        if (radio.checked) {
            checkedRadio = radio;
            break;
        }
    }

    // x === y, !==, x == y, !=
    if (checkedRadio != null) {
        var result = calculate(checkedRadio, firstValue, secondValue);
        resultArray.push(result);
        window.alert("result: " + result)
    }
    else {
        window.alert('make a proper choice');
    }
}
function showAllClicked() {
    if (resultArray.length > 0) {
        for (var index = 0; index < resultArray.length; index++) {
            var result = resultArray[index];
            window.alert(result);
        }
    }
}

function calculate(radio, first, second) {
    var result = 0;
    switch (radio.value) {
        case 'Add':
            result = first + second;
            break;

        case 'Subtract':
            result = first - second;
            break;

        case 'Multiply':
            result = first * second;
            break;

        case 'Divide':
            result = first / second;
            break;

        default:
            break;
    }
    return `${radio.value} result is ${result}`;
}


function getElement(elementId) {
    return document.getElementById(elementId);
}

function getValue(txtBox) {
    return parseInt(txtBox.value);
}

function add(first, second) {
    return (first + second);
}
