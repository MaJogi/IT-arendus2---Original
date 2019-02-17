let a = [4, 8, 15, 16, 23, 42];
let b = ['david','eddie', 'alex','marko']

console.log(a[0]);
console.log(a[1]);
console.log(a);

a[0] = 7;
console.log(a);
console.log(typeof a);

let c = [4, 'alex', true];
console.log(c);

console.log(a.length); // actual number, NOT zero based

a[10] = 77;
console.log(a);
console.log(a.length);

a.push(88);
console.log(a);
console.log(a.length);