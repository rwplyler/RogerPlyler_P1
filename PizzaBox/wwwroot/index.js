

function testJSON() {
    const bodies = {
        fname: "Roger",
        lname: "Plyler"
    };

    fetch('api/Acustomer', {
        method: 'POST',
        body: JSON.stringify(bodies),
        headers: { 'Content-Type': 'application/json' },
    })
        .then(res => res.json())
        .then(json => console.log(json));
}

testJSON();

fetch('api/Ainventorydetail')
    .then(response => { response.json(); })
    .then(data => { console.log(data); });