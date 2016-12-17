$(function () {
    alert('HEll YEah');
    getAllPlanetsInformation();

    $('.planet').click(function (e) {
        var planetName = $(e.toElement).attr('data-name');

        planet.displayInformation(planetName);
    });
});

function getAllPlanetsInformation() {
    var data = dataService.getAllPlanetsData();
    alert(data + '2');
}

