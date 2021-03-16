//there is no scoping of variables in JS
//hoisting
// var a = 10;
// for (var i = 0; i < 2; i++) {
//     var a = 20;
//     console.log(a)
// }
// console.log(a)

//let keyword helps you to declare scoped variables (2015 - ES6)
let a = 10;
for (let i = 0; i < 2; i++) {
    let a = 20;
    console.log(a)
}
console.log(a)

//ES6 (2015)
const m = 10;
//m = 20;
console.log(m)
const arr = [10, 20];
//arr = [1, 2, 3]
arr.push(1);
console.log(arr)


var employees = [];
var getElement = (elementId) => document.getElementById(elementId);
var getValue = (element) => {
    return element.value;
}

//constructor function
function employee(empId, empName, empBasic, empDa, empHra) {
    //value properties
    this.employeeName = empName;
    this.employeeId = empId;
    this.employeeBasicPay = empBasic;
    this.employeeDaPay = empDa;
    this.employeeHraPay = empHra;
    this.employeeSalary = 0;

    //functional property
    this.calculateSalary = function () {
        this.employeeSalary = this.employeeBasicPay + this.employeeDaPay + this.employeeHraPay;
    }
    //return this;
}


function addRecord() {
    var txtName = getElement('txtName');
    var txtId = getElement('txtId');
    var txtBasic = getElement('txtBasic');
    var txtDa = getElement('txtDa');
    var txtHra = getElement('txtHra');

    var name = getValue(txtName);
    var id = parseInt(getValue(txtId));
    var basic = parseFloat(getValue(txtBasic));
    var da = parseFloat(getValue(txtDa));
    var hra = parseFloat(getValue(txtHra));

    var emp = new employee(id, name, basic, da, hra);
    // console.log(emp.employeeName);
    // console.log(emp["employeeId"])
    emp.calculateSalary();

    // for (var propName in emp) {
    //     var propValue = emp[propName];
    //     console.log(`${propName}:${propValue}`)
    // }

    employees.push(emp);
    console.log(employees)
}

function showRecords() {
    if (employees.length > 0) {

        var ddl = getElement('ddlEmployee');
        var recordsTable = getElement('tblRecords');

        var empData = employees[0];

        var i = 0;
        for (var propName in empData) {
            // console.log(typeof (empData[propName]))
            if (typeof (empData[propName]) !== "function") {
                var option = document.createElement('option');
                option.value = i;
                option.text = propName.toUpperCase();
                ddl.appendChild(option);
                i++;
            }
        }

        for (var index = 0; index < employees.length; index++) {
            var emp = employees[index];



            var row = document.createElement('tr');
            //var rowId = document.createAttribute('id');
            row.setAttribute('id', `row${emp.employeeId}`)

            console.log(row)

            var nameColumn = document.createElement('td');
            nameColumn.innerHTML = emp.employeeName;

            var idColumn = document.createElement('td');
            idColumn.innerHTML = emp.employeeId;

            var basicColumn = document.createElement('td');
            basicColumn.innerHTML = emp.employeeBasicPay;

            var daColumn = document.createElement('td');
            daColumn.innerHTML = emp.employeeDaPay;

            var hraColumn = document.createElement('td');
            hraColumn.innerHTML = emp.employeeHraPay;

            var salaryColumn = document.createElement('td');
            salaryColumn.innerHTML = emp.employeeSalary;

            row.appendChild(idColumn);
            row.appendChild(nameColumn);
            row.appendChild(basicColumn);
            row.appendChild(daColumn);
            row.appendChild(hraColumn);
            row.appendChild(salaryColumn);


            recordsTable.appendChild(row);


        }
    }
}
function sortEmployees() {
    var ddl = getElement('ddlEmployee');
    var selectedCriteria = null;
    for (var index = 0; index < ddl.options.length; index++) {
        if (ddl.options[index].selected === true) {
            selectedCriteria = ddl.options[index];
            break;
        }
    }
    var emp = employees[0];

    var sortedArray = null;
    switch (selectedCriteria.text) {
        case "EMPLOYEENAME":
            //arrow operator (2015 - ES6)
            sortedArray = employees.sort((e1, e2) => {
                if (e1.employeeName !== e2.employeeName) {
                    if (e1.employeeName > e2.employeeName)
                        return 1;
                    else
                        return -1;
                }
                else
                    return 0;
            })
            break;

        case "EMPLOYEEID":
            sortedArray = employees.sort((e1, e2) => {
                if (e1.employeeId !== e2.employeeId) {
                    if (e1.employeeId > e2.employeeId)
                        return 1;
                    else
                        return -1;
                }
                else
                    return 0;
            });
            break;

        case "EMPLOYEEBASICPAY":

            break;

        case "EMPLOYEEDAPAY":

            break;

        case "EMPLOYEEHRAPAY":

            break;

        case "EMPLOYEESALARY":
            sortedArray = employees.sort((e1, e2) => {
                if (e1.employeeSalary !== e2.employeeSalary) {
                    if (e1.employeeSalary > e2.employeeSalary)
                        return 1;
                    else
                        return -1;
                }
                else
                    return 0;
            });
            break;

        default:
            break;
    }
    console.log(sortedArray);
}