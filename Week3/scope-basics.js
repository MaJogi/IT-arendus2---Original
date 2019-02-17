let a = 'first';

function scopeTest() {
    console.log(a);
    a = 'changed';
    if (a != '') {
        console.log(a);
    }
    //let b = 'second';
}

scopeTest();
//console.log(b);