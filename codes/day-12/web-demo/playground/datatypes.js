/**
 * types of data:
 * number (integer, float, etc...)
 * boolean
 * string
 * object
 * array (also an object)
 *
 * loosely typing
 * var x = 10;
 * x = false;
 */

var x = 10;
console.log(typeof (x))
x = false;
console.log(typeof (x))
x = 12.34
console.log(typeof (x))
x = 'epsilon'
console.log(typeof (x))
x = new Array(1, 2, 3, 4);

//w3c
//javascript new feature in 2015 (ES6)
//string literal (string template literal/interploation)
console.log(`length:${x.length}`)
console.log(typeof (x))

//C# feature
//console.writeline($"{x.length}")


x = {
    name: 'joydip',
    id: 1,
    subject: 'dotnet'
}
console.log(typeof (x))