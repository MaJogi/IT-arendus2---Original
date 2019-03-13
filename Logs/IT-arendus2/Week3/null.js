// let a;
// console.log(a);
// console.log(typeof a);

let pattern = /xyz/;
let value = "This is a test";
let result = value.match(pattern);
console.log(result);
//console.log(typeof result); //object lol, javascript issue that's not fixed

if (result === null) {
    console.log("no match was found");
}