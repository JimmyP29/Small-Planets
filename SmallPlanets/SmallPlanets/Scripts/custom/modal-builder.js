var modalBuilder = {
    createPlanetModal: function (planet) {
        document.getElementById('planet_image').src = imageHelper.decodeImage(planet.Image);
        $('#planet_header_title').text(planet.Name);
        $('h2').css('font-family', '\'Space Mono\', monospace');
        $('#span_distance').text(planet.DistanceFromSun);
        $('#span_mass').text(planet.Mass);
        $('#span_diameter').text(planet.Diameter);
        $('#p_additional').typed({
            strings: [planet.AdditionalInformation],
            typeSpeed: 0
        });

        $('#planet_modal').modal();
    },
    createLogModal: function (log) {
        if (log.length === 0) {
            $('#span_empty_log_message').show();
            $('#log_table').hide();
            $('#log_titles').hide();
            $('#button_clear').prop('disabled', true);
        } else {
            var rows = '';

            $.each(log, function (i, e) {
                var dateTime = e.Visited;
                rows += '<tr class="row text-center">' +
                            '<td class="col-lg-2">' +
                                '<img class="image_log_planet" src="' + imageHelper.decodeImage(e.PlanetImage) + '" />' +
                            '</td>' +
                            '<td class="col-lg-3">' +
                                '<span>' + e.PlanetName + '</span>' +
                            '</td>' +
                            '<td class="col-lg-7">' +
                                '<span>' + dateTimeHelper.convertToReadableString(dateTime) + '</span>' +
                            '</td>' +
                        '</tr><hr />';
                dateTime = null;
            });
            $('#span_empty_log_message').hide();
            $('#button_clear').prop('disabled', false);
            $('#log_table').show();
            $('#log_titles').show();
            $('#log_table tr').html(rows);
        }
        $('#log_modal').modal();
    }
};