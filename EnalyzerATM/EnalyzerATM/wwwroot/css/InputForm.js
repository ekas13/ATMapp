
.numpad - container {
    display: flex;
    flex - direction: column;
    align - items: center;
    justify - content: center;
    text - align: center;
    height: 100vh;
    margin - top: 30px;
}

numpad - container h2 {
    text - align: center;
    font - size: 40px;

}

.input - display {
    margin - bottom: 20px;
    border: none;
    display: flex!important;
    align - items: center!important;

}

.input - label {
    font - size: 80px!important;
    display: inline - block!important;
    width: auto!important;
    font - weight: bold;
}

.input - display input {
    height: 90px!important;
    font - size: 80px!important;
    border: none!important;
    background - color: transparent;
    padding: 5px;
    text - align: center;
    color: white;
    font - weight: bold;
}


.numpad {
    display: grid;
    grid - template - columns: repeat(3, 100px);
    gap: 5px;
    grid - row - gap: 10px;
    border - radius: 10px;
    padding: 10px;
    background - color: transparent;

}


    .numpad button {
    width: 100px;
    height: 100px;
    font - size: 40px;
    background - color: transparent;
    border - radius: 50 %;
    border: 1px solid white;
    cursor: pointer;
    transition: background - color 0.3s;
    display: flex;
    align - items: center;
    justify - content: center;
    margin - top: 5px;
    margin - bottom: 5px;
    color: white;
}

    .numpad button:hover {
    color: #2bbed3;
}


    .numpad.backspace {
    background - color: transparent;
}


#submitButton:disabled {
    background - color: transparent;
    color: lightgray;
    border - color: lightgray;
}


#submitButton: hover:enabled {
    color: #2bbed3;
}

.submit - button {
    margin - top: 20px;
}


    .submit - button button {
    width: 300px;
    height: 60px;
    font - size: 40px;
    background - color: transparent;
    color: #ffffff;
    border: 1px solid;
    border - radius: 30px;
    cursor: pointer;
    transition: background - color 0.3s;
    display: flex;
    align - items: center;
    justify - content: center;
}


        .numpad button: hover, .submit - button button:hover {
    background - color: #dcdcdc;
}


.input - display input {
    width: 200px;
    height: 40px;
    font - size: 16px;
    border: 1px solid #ccc;
    border - radius: 5px;
    padding: 5px;
    text - align: center;
}
