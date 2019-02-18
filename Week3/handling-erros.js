// let a = 7 * undefined / "panama";
// console.log(a);


// beforeTryCatch();

// function afterTryCatch() {
//     try {
//         function beforeTryCatch() {
//             let obj = undefined;
//             console.log(obj.b);
//             console.log("you will not see this becouse error happen");
//         }
        
//     } catch (error) {
//         console.log("Error! " + error.message);
//     } finally {
//         console.log("This will happen no matter what.")
//     }

// }

function performCalulation(obj) {
    if (!obj.hasOwnProperty("b")) {
        throw new Error("Object missing property");
    }
    return 6;
}

function performHigherLevelOperation() {
    let obj;
    let value = 0;
    try {
        value = performCalculation(obj);
    } catch (error) {
        console.log(error.message);
    }
}