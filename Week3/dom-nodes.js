(function() {

    function incrementCounter() {
        counter = counter + 1;
    }
    
    function updateUI() {
        
      const colors = [
        { name: 'Alizarin' , value: '#e74c3c' },
        { name: 'Belize Hole' , value: '#2980b9' },
        { name: 'Emerald' , value: '#2ecc71' },
        { name: 'Midnight Blue' , value: '#2c3e50' },
        { name: 'Sun Flower' , value: '#f1c40f' },
        { name: 'Pumpkin' , value: '#d35400' },      
      ];
      
        let result = document.getElementById('resultDiv');

        // Relatiivne elemendi fondi suurusele
        // 2em tähendab 2 korda suurem font, kui muidu on/oli)
        result.innerText = counter;
        if (counter > 0) {
            result.style.fontSize = counter + 'em';
        }
    
        // Divide first into second, return the remainder.
        // Access that element of the colors array to grab
        // the color object:
        let remainder = counter % colors.length;
        result.style.color = colors[remainder].value;
    
        // Puhasta ära kõik olemasolevad child color divs
        let colorDiv = document.getElementById('colorDiv');        
        colorDiv.innerHTML = '';

        // Lisa uuesti child color divs
        for(i = 0; i < colors.length; i++) {

            // Node loomine dünaamiliselt kavatsusega tema lisamist colorDiv'ile.
            var node = document.createElement('div');
            var textnode = document.createTextNode(colors[i].name);
            node.appendChild(textnode);
            node.style.backgroundColor = colors[i].value;

            // Alternatiivselt, ma oleksin võinud selle teha css.
            // style and added that to the node.classList ...            
            node.style.width = '150px';
            node.style.height = '50px';
            node.style.cssFloat = 'left';
            node.style.paddingLeft = '10px';
            node.style.paddingTop = '10px';
    
            if (i == remainder) {
                node.style.height = '45px';

                // Näidis: klassi lisamine node'i
                // classList.
                node.classList.add('selected');
            }
    
            colorDiv.appendChild(node);        
        }
    }
    
    function handleClick() {
        incrementCounter();
        updateUI();
    }    

    let counter = 0;

    let myButton = document.getElementById('myButton');
    myButton.addEventListener('click', function() { 
        incrementCounter();
        updateUI();
    } );

    updateUI();    

})();