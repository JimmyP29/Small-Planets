$(function () {
    loadMissionStatement();
    $('body').css('background-color', '#000');
    $('[data-toggle="tooltip"]').tooltip();

    $('.planet').click(function (e) { 
        dataService.loadPlanet($(e.toElement).attr('data-planet-name'));
        var planet = JSON.parse(decodeURIComponent($('#hidden-planet').val()));

        if (planet !== undefined) {
            displayInformation(planet);
        } else {
            console.log('Planet is undefined');
        }
    });

    $('#captains_log').click(function () {
        displayCaptainsLog();
    });
});

function displayInformation(planet) {
    document.getElementById('planet-image').src = 'data:image/jpeg;base64,' + planet.Image;
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

function displayCaptainsLog() {
    dataService.loadLog();
}

