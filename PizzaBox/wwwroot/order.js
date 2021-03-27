var customerID;
var storeID;
var total;
var itemPrice = [0.00];
var itemID = [0];

//Inputs feilds
var storeInput = document.getElementById("stores");


function createStoreOptions() {
    fetch('api/Astore')
        .then(response => response.json())
        .then(data => { data.forEach(store => storeInput.add(new Option(store.storeName,store.id))); });
           
}
createStoreOptions();

function findCustomer(FirstName, LastName) {
    fetch('api/Acustomer/' + FirstName + '/' + LastName)
        .then(response => response.json())
        .then(data => { console.log(data); });
}

function viewstores(id) {
    fetch('api/Aorder/' + id + '/store')
        .then(response => response.json())
        .then(data => { console.log(data); } );
} 

function avalibleItems(id) {

}