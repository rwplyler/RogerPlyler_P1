const api_url =
    "api/Acustomer";

// Defining async function
async function getapi(url) {

    // Storing response
    const response = await fetch(url);

    // Storing data in form of JSON
    var data = await response.json();
    console.log(data[0].id);
    console.log(data);
    if (response) {
        hideloader();
    }
    show(data[0]);
}
// Calling that async function
getapi(api_url);

// Function to hide the loader
function hideloader() {
    document.getElementById('loading').style.display = 'none';
}
// Function to define innerHTML for HTML table
function show(r) {
    let tab =
        `<tr>
          <th>ID</th>
          <th>CustomerName</th>
          <th>Location ID</th>
         </tr>`;

    // Loop to access all rows 

        tab += `<tr> 
    <td>${r.id} </td>
    <td>${r.customerName}</td>
    <td>${r.locationId}</td>  
</tr>`;
    
    // Setting innerHTML as tab variable
    document.getElementById("employees").innerHTML = tab;
}