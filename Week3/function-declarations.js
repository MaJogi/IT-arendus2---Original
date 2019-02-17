function sayHello() { //meaningful name
    console.log('hello!');
}

sayHello();
let a = sayHello; //refrence to the function
a(); //The way i invoke a function in a variable

function sayHello(name) { //meaningful name
    console.log('hello ' + name + "!");
}

sayHello('bob');

function calculateTax(amount){
    let result = amount * 0.0825
    return result;
}

let tax = calculateTax(100);
console.log(tax);