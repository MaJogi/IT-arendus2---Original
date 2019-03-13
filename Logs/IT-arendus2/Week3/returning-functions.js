// // DON'T DO THIS!!!
// var myVariable = 'I am at the global scope';

// //This either!!!
// var myFunction = function() {
//     console.log('me too!');
// }

function one() {
    return 'one';
}

// let value = one();
// console.log(value);
// console.log(one());

let value = one;
// console.log(typeof value);
// console.log(typeof one);
console.log(value());

// string
// number
// boolean
// undefined
// function

function two() {
    return function () {
        console.log('two');
    }
}

let myFunction = two();
myFunction();
