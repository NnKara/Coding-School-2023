
//       EXERCISE  1&2


function reverseString(str) {
    return str.split("").reverse().join("");
  }

  function displayResult() {
    let input = document.getElementById("input").value;
    let reversed = reverseString(input);
    let result = isPalindrome(reversed);

    if (result) {
      document.getElementById("output").innerHTML = `The reversed string "${reversed}" is a palindrome!`;
    } else {
      document.getElementById("output").innerHTML = `The reversed string "${reversed}" is not a palindrome!`;
    }
}
function isPalindrome(str) {
    return str === str.split('').reverse().join('');
  }

  //       EXERCISE 3

  let customers = [];

  function addCustomer() {
    let name = document.getElementById("name").value;
    let surname = document.getElementById("surname").value;
    let age = document.getElementById("age").value;
    let gender = document.getElementById("gender").value;
  
    let customer = { name, surname, age, gender };
    customers.push(customer);
    updateTable();
  }

  function updateTable(){

  }

  function selectedCustomerDetails(customer) {
    let displayName = document.querySelector('#displayName');
    let displaySurname = document.querySelector('#displaySurname');
    let displayAge = document.querySelector('#displayAge');
    let displayGender = document.querySelector('#displayGender');

    displayName.value = customer.name;
    displaySurname.value = customer.surname;
    displayAge.value = customer.age;
    displayGender.value = customer.gender;
}


//          EXERCISE  4


  function multiply(a, b) {
    return a * b;
  }

  function displayResult4() {
    let inputA = parseFloat(document.getElementById("inputA").value);
    let inputB = parseFloat(document.getElementById("inputB").value);
    if (isNaN(inputA) || isNaN(inputB)) {
      document.getElementById("output4").innerHTML = "You have to add Both inputs & Both inputs must be numbers.";
    } else {
      let result4 = multiply(inputA, inputB);
      document.getElementById("output4").innerHTML = "Result: " + result4;
    }
  }




//         EXERCISE 5


  function incrementString(input) {
    let lastChar = input.slice(-1);
    if (!isNaN(lastChar)) {
      let num = parseInt(lastChar);
      num++;
      return input.slice(0, -1) + num;
    }
    return input + "1";
  }

  function displayResult5() {
    let input = document.getElementById("input5").value;
    let result = incrementString(input);
    document.getElementById("output5").innerHTML = "Result: " + result;
  }
  
