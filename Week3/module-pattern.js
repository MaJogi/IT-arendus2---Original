var counter = (function() {
    
    // private stuff
    let count = 0;

    function print(message){
        console.log("" + "---" + count)
    }

    // return an object
    return {
        value: count,

        increment: function() {
            count += 1;
            print("After increment: ");
        },

        reset: function() {
            print("Before reset: ");
            count = 0;
            print("After reset: ");
        }
    }
})();

console.log(counter.count);
console.log(counter.value);
