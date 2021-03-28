var customerID;
var storenum;
var total;
var itemPrice = [0.00];
var itemID = [0];
var pendingItem = 0;

//item that will persist the Cart;
var fullCart = [];

class Cart{
    constructor(cartItem, cartAmount,storeID) {
        this.cartItem = cartItem;
        this.cartAmount = cartAmount;
        this.storeID = storeID;

        this.getName = function () {
            return "User's name: " + this.firstName + " " + this.lastName;
        }
    }
}



//Inputs feilds
var storeInput = document.getElementById("stores");
var itemInput = document.getElementById("items");
var amountInput = document.getElementById("amount");
var cartInput = document.getElementById("cart");

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
    storenum = id;
    fetch('api/Ainventorydetail/' + id)
        .then(response => response.json())
        .then(data => { addToInventory(data); })
} 

function addToInventory(stock) {
    stock.forEach(item => {
        if (item.amount > 0) {
            console.log(item.itemId);
            var input = parseInt(item.itemId);
            fetch('api/Anitem/' + input)
                .then(Response => Response.json())
                .then(data => { itemInput.add(new Option(data.itemName, data.id)); });
        }
    });
}

function pendingCart(itemNum) {
    pendingItem = itemNum;
    itemAmount = 0;
    fetch('api/Ainventorydetail/' + itemNum + '/' + storenum)
        .then(response => response.json())
        .then(data => {
            itemAmount = data.amount;
            for (i = 1; i <= itemAmount; i++) {
                amountInput.add(new Option(i, i));
            }
        });
    
    
}

function addToCart(amount) {
    var newItem = new Cart(pendingItem, amount, storenum);
    fullCart.push(newItem);
    console.log(fullCart);
    updateCart();

}

function updateCart() {
    
    for (i = 0; i < fullCart.length; i++) {
        cartInput.add(new Option(fullCart[i].cartItem, i));
        }

}

