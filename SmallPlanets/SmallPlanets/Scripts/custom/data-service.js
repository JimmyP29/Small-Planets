var dataService = {
    loadPlanet: function (planetName) {
        $.ajax({
            async: false,
            url: domain.path + '/SolarSystem/LoadPlanet?planetName=' + planetName,
            dataType: 'json',
            type: 'POST',
            contentType: 'application/json; charset=utf-8',
            success: function (planet) {
                $('#hidden-planet').val(encodeURIComponent(JSON.stringify(planet)));
            },
            fail: function () {
                console.log("FAIL - Couldn't retrieve planet data");
                return null;
            }
        });
    },

    loadLog: function () {
        $.ajax({
            async: false,
            url: domain.path + '/Log/GetCaptainsLog',
            type: 'GET',
            contentType: 'application/json; charset=utf-8',
            success: function (log) {
                console.log(log);
            },
            fail: function () {
                console.log("FAIL - Couldn't retrieve log data");
            }
        });
    }
};

var domain = {
    path: 'http://' + location.hostname + ':' + location.port
};