// let name = "bob";
// console.log(`hi ${name}`);


// let sentence = `LLONGGGGGGGGGGGGGGGGGGGGG
//     GGGGGGGGGGGGGGGGGG
//         GGGGGGGGGGGGG
//             GGGGGGG`;
// console.log(sentence);

function getReasonCount() { return 2; }

let interpolation = `Give me ${getReasonCount() == 1 ? "one good reason" : "a few reason"} to try this.`

console.log(interpolation);