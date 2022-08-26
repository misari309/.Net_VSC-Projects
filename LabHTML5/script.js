function setName(){
    let name = prompt("Enter the name: ");
    const dinamic_name_collection = document.querySelectorAll(".dinamic_name");
    dinamic_name_collection.forEach(element =>{
        element.textContent=name;
    })
}

function setLastName(){
    let lastName = prompt("Enter the last name: ");
    const dinamic_lastName_collection = document.querySelectorAll(".dinamic_lastName");
    dinamic_lastName_collection.forEach(element => {
        element.textContent=lastName;
    })
}

const btn_not = document.querySelector("#btn_not");
btn_not.addEventListener("click", makeVisible);

function makeVisible(){
    document.getElementById("dont_open").style.visibility='visible';
}