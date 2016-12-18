$(function () {
    //alert('HEll YEah');
   // loadSolarSystem();

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
    $('.modal-header').text(planet.Name);

    $('#planet-modal').modal();
}

