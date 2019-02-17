
let car = {
    make: 'bmw',
    model: '745li',
    year: 2010,
    getPrice: function() {
        return 5000;
    },
    printDescription: function() { //this refers to this object (car)
        console.log(this.make + ' ' + this.model);
    }
}

car.printDescription();
console.log(car.year);

console.log(car['year']);

var anotherCar = {};

anotherCar.whatever = 'bob';

var a = {
    myProperty: { b: 'hi' } //has an object in it
};

console.log(a.myProperty.b);

// var c = {
//     myProperty: [
//         { d: 'this'},
//         { e: 'can'},
//         { f: 'get'},
//         { g: 'crazy'},
//     ]
// }

let carLot =  [
    { year: 2017, make: 'Toyota', model: '4Runner'},
    { year: 2015, make: "BMW", model: "528i"},
    { year: 1982, make: "Buick", model: "Skylark" },

];

let contacts = {
    customers: [
        {firstName: "Bob", lastName: "Tabor", phoneNumbers: ['456-7890', "123" ] },
        {firstName: "Richard", lastName: "Boughton", phoneNumbers: ["12","1234" ] }
    ],
    employees: [
        { firstName: "Steve", lastName: "Kavalski", phoneNumbers: ["123", "321" ] },
        { firstName: "Jhon", lastName: "Kavalski", phoneNumbers: ["123", "321" ] },
    ]
};