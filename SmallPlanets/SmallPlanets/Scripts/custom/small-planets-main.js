var currentLog = null;

$(function () {
    var currentPlanet = null;
    loadUI();

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

    $('#button_close_planet').click(function () {
        saveVisit(currentPlanet);
        currentPlanet = null;
    });

    $('#button_captains_log').click(function () {
        displayCaptainsLog();
    });

    $('#button_clear').click(function () {
        clearCaptainsLog();
       
    }).mouseover(function () {
        loadWarningStatement();
    });

    $('#button_log_close').click(function () {
        $('#warning_label').hide();
    });
});



function loadMissionStatement() {
    $('#label_mission_statement').typed({
        strings: ['Mission 1.293a "Small Planets"   ', 'Click "Captains Log" to view previous visits, or...   ', 'Click Planets to commence Mission...   '],
        typeSpeed: 0
    });
}

function loadWarningStatement() {
    $('#warning_label').show().typed({
        strings: ['WARNING - Destroy all Log entries?'],
        typeSpeed: 1
    });
}

function loadUI() {
    loadMissionStatement();
    $('body').css('background-color', '#000');
    $('[data-toggle="tooltip"]').tooltip();
}

function displayInformation(planet) {
    modalBuilder.createPlanetModal(planet);
}

function displayCaptainsLog() {
    currentLog = null;
    var log = dataService.loadLog(function (log) {
        if (log !== undefined) {
            currentLog = log;
            modalBuilder.createLogModal(currentLog);
        }

    });
}

function clearCaptainsLog() {
    var data = dataService.clearLog(currentLog);
    $('#warning_label').hide();
    currentLog = null;
}

function saveVisit(planet) {
    var log = createLogEntry(planet);
    dataService.saveVisit(log);
}

function createLogEntry(planet) {
    var formattedDateString = dateTimeHelper.convertToReadableString(new Date());
    return { PlanetName: planet.Name, PlanetImage: planet.Image, Visited: formattedDateString };
}

