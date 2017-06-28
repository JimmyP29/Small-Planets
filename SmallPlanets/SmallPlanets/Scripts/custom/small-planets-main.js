$(function () {
    loadMissionStatement();
    $('body').css('background-color', '#000');
    $('[data-toggle="tooltip"]').tooltip();

    var currentPlanet = null;

    $('.planet').click(function (e) {
        var planet = dataService.loadPlanet($(e.toElement).attr('data-planet-name'), function (planet) {
            if (planet !== undefined) {
                console.log("oh yeah here's your planet...");
                console.log(planet);
                currentPlanet = planet;
                displayInformation(planet);
            } else {
                console.log('Planet is undefined');
            }
        });
    });

    $('#close_button').click(function () {
        var planet = currentPlanet;
        saveVisit(planet);
        currentPlanet = null;
    });

    $('#captains_log').click(function () {
        displayCaptainsLog();
    });
});

function displayInformation(planet) {
    document.getElementById('planet-image').src = decodeImage(planet.Image);
    $('.modal-title').text(planet.Name);
    $('h2').css('font-family', '\'Space Mono\', monospace');
    $('#span-distance').text(planet.DistanceFromSun);
    $('#span-mass').text(planet.Mass);
    $('#span-diameter').text(planet.Diameter);
    $('#p-additional').typed({
        strings: [planet.AdditionalInformation],
        typeSpeed: 0
    });

    $('#planet-modal').modal();
}

function loadMissionStatement() {
    $('#mission-statement').typed({
        strings: ['Mission 1.293a "Small Planets"   ', 'Click Planets to commence Mission...   '],
        typeSpeed: 0
    });
}

function decodeImage(image) {
    return 'data:image/jpeg;base64,' + image;
}

function displayCaptainsLog() {
    var log = dataService.loadLog(function (log) {
        if (log !== undefined) {
            console.log('yep');
            console.log(log);
        }

    });
}

function saveVisit(planet) {
    var log = createLogEntry(planet);
    dataService.saveVisit(log);
}

function createLogEntry(planet) {
    return { PlanetName: planet.Name, PlanetImage: planet.Image, Visited: new Date('29/03/2017') };
}

