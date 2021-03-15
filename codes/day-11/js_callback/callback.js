function add(a, b) {
    return (a + b);
}

function multiply(a, b) {
    return (a * b);
}

function calculate(operation, x, y) {
    return operation(x, y);
}
function call() {
    var res = calculate(add, 10, 12);
    console.log(res);
}
call();