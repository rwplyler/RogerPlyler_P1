function register(FirstName,LastName) {
    const bodies = {
        fname: FirstName,
        lname: LastName
    };

    fetch('api/Acustomer', {
        method: 'POST',
        body: JSON.stringify(bodies),
        headers: { 'Content-Type': 'application/json' },
    })
        .then(response =>  response.json() )
        .then(data => {
            if (data.id == 0) {
                alert("Customer Already Registered");
            } else {
                alert("Thank you for registering" + FirstName + " " + LastName);
                customerID = data.id;
            }
        });

}