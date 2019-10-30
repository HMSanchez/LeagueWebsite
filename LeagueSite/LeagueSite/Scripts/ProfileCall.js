
function UserAction() {
    var xhttp = new ;
    xhttp.open("GET", 'https://na1.api.riotgames.com/lol/summoner/v3/summoners/by-name/SearingDarkness?api_key=RGAPI-ac5da9b8-6a44-4362-b30c-8fff3c85c296', true);
    xhttp.setRequestHeader("Content-type", "application/json");
    xhttp.send();
    var response = JSON.parse(xhttp.responseText);
}