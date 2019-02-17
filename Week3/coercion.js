let a = 7;
let b = '6';
b = parseInt(b, 10); //10 for decimal conversion
let c = a + b; //concatinating together number and string to form string
console.log('Answer: ' + c);

let d = parseInt('bob', 10);
let e = isNan(d);
console.log(d);
console.log(e);