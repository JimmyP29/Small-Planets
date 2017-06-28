$(function () {
    loadMissionStatement();
    $('body').css('background-color', '#000');
    $('[data-toggle="tooltip"]').tooltip();

    var currentPlanet = null;

    $('.planet').click(function (e) {
        var planet = dataService.loadPlanet($(e.toElement).attr('data-planet-name'), function (planet) {
            if (planet !== undefined) {
                currentPlanet = planet;
                displayInformation(planet);
            } else {
                console.log('Planet is undefined');
            }
        });
    });

    $('#button_close').click(function () {
        var planet = currentPlanet;
        saveVisit(planet);
        currentPlanet = null;
    });

    $('#button_captains_log').click(function () {
        displayCaptainsLog();
    });
});

function displayInformation(planet) {
    modalBuilder.createPlanetModal(planet);
}

function loadMissionStatement() {
    $('#label_mission_statement').typed({
        strings: ['Mission 1.293a "Small Planets"   ', 'Click Planets to commence Mission...   '],
        typeSpeed: 0
    });
}

function displayCaptainsLog() {
    var log = dataService.loadLog(function (log) {
        if (log !== undefined) {
            console.log('yep');
            console.log(log);
            modalBuilder.createLogModal(log);
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

