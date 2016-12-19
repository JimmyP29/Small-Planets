$(function () {
    //alert('HEll YEah');
    // loadSolarSystem();
    $('body').css('background-color', '#000');
    $('[data-toggle="tooltip"]').tooltip();

    $('.planet').click(function (e) {
        //var planetName = $(e.toElement).attr('data-planet-name');
        //dataService.loadPlanet(planetName);  
        dataService.loadPlanet($(e.toElement).attr('data-planet-name'));
        var planet = JSON.parse(decodeURIComponent($('#hidden-planet').val()));

        if (planet !== undefined) {
            displayInformation(planet);
        } else {
            alert('Nah');
        }
    });
});

function displayInformation(planet) {
    document.getElementById('planet-image').src = 'data:image/jpeg;base64,' + planet.Image;
    // $('.modal-header').replaceWith('<h2><b>' + planet.Name + '</b></h2>');
    $('.modal-title').text(planet.Name);
    $('h2').css('font-family', '\'Space Mono\', monospace');
    $('#span-distance').text(planet.DistanceFromSun);
    $('#span-mass').text(planet.Mass);
    $('#span-diameter').text(planet.Diameter);
    $('#p-additional').typed({
        //strings: planet.AdditionalInformation,
        strings: [planet.AdditionalInformation],
        typeSpeed: 0
    });
        //.text(planet.AdditionalInformation);

    $('#planet-modal').modal();
}

