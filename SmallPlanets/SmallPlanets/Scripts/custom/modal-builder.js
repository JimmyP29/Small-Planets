var modalBuilder = {
    createPlanetModal: function (planet) {
        document.getElementById('planet-image').src = imageHelper.decodeImage(planet.Image);
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
    },
    createLogModal: function (log) {
        var rows = '';
        
        $.each(log, function (i, e) {
            rows += '<tr>' +
                        '<td class="col-lg-2">' +
                            '<img class="image-log-planet" src="' + imageHelper.decodeImage(e.PlanetImage) + '" />' +
                        '</td>' +
                        '<td class="col-lg-5">' +
                            '<span>' + e.PlanetName + '</span>' +
                        '</td>' +
                        '<td class="col-lg-5">' +
                            '<span>' + e.Visited + '</span>' +
                        '</td>' +
                    '</tr><hr />';
        });
        $('#log_table').append(rows);
        $('#log-modal').modal();
    }
};