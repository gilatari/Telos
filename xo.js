const defaultSize = 3;
var stateSign = 'x';
var size = defaultSize;


function drawSign() {


    if (this.getAttribute('disabledButton')) {
        alert("botton is off");
    } else {


        this.innerHTML = stateSign;

        if (stateSign === 'x')
            stateSign = 'o';
        else
            stateSign = 'x';

    }

    this.setAttribute('disabledButton', 'true')
}

function onChangeSize() {
    size = document.getElementById('size').value;


    var board = document.getElementById('board');
    board.removeChild(board.firstChild);
    var innerBoard = document.createElement("DIV");
    board.appendChild(innerBoard);

    for (var cols = 0; cols < size; cols++) {
        var row = document.createElement("DIV");
        innerBoard.appendChild(row);

        for (var rows = 0; rows < size; rows++) {
            row.appendChild(document.createElement("BUTTON")).addEventListener('click', drawSign);
        }
    }

}