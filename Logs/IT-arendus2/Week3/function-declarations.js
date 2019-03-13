function sayHello() { 
    console.log('hello!');
}

sayHello();
let a = sayHello; //refrence to the function
a(); //Viis, kuidas saab välja kutsuda funktsiooni muutujast

function sayHello(name) { 
    console.log('hello ' + name + "!");
}

sayHello('bob');

function calculateTax(amount){
    let result = amount * 0.0825
    return result;
}

let tax = calculateTax(100);
console.log(tax);