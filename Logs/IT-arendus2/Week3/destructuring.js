// let a, b, c, d, e;

let names = ['david', "eddie", "alex", "michael"];

// [a, b, c, d] = names;

// let others;

// [a, b, ...others] = names;

// console.log(a);
// console.log(b);
// console.log(others);

let year, model;

({year, model} = {
    make: "bmw",
    model: "745li",
    year: 2010,
    value: 5000
});

console.log(year);
console.log(model);

