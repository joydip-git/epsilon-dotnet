var employees = [];
function getElement(elementId) {
    return document.getElementById(elementId);
}
function getValue(element) {
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

    var str='';
    

    var sortedArray = null;
    switch (selectedCriteria) {
        case "EMPLOYEENAME":
            sortedArray = employees.sort()
            break;

        case "EMPLOYEEID":
            sortedArray = employees.sort(e => e.employeeId);
            break;

        case "EMPLOYEEBASICPAY":

            break;

        case "EMPLOYEEDAPAY":

            break;

        case "EMPLOYEEHRAPAY":

            break;

        case "EMPLOYEESALARY":
            sortedArray = employees.sort(e => e.employeeSalary);
            break;

        default:
            break;
    }
    console.log(sortedArray);
}