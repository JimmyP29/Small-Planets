var dataService = {
    loadPlanet: function (planetName) {
        $.ajax({
            async: false,
            url: domain.path + '/SolarSystem/LoadPlanet?planetName=' + planetName,
            dataType: 'json',
            type: 'POST',
            contentType: "application/json; charset=utf-8",
            success: function (planet) {
                $('#hidden-planet').val(encodeURIComponent(JSON.stringify(planet)));
            },
            fail: function () {
                console.log("FAIL - Couldn't retrieve planet data");
                return null;
            }
        });
    }
};

var domain = {
    path: 'http://' + location.hostname + ':' + location.port
};