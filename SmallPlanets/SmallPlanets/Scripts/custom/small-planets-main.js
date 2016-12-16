$(function () {
    alert('HEll YEah');
   

    $('.planet').click(function (e) {
        var planetName = $(e.toElement).attr('data-name');

        planet.displayInformation(planetName);
    });
});

