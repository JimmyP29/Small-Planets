var dataService = {
    getAllPlanetsData: function () {
        $.ajax({
            url: domain.path + '/SolarSystem/LoadSolarSystemData',
            dataType: 'json',
            type: 'POST',
            success: function(data){
                alert(data + '1');
            },
            fail: function () {
                alert('FAIL');
            }
        });
    }
};

var domain = {
    path: 'http://' + location.hostname + ':' + location.port
};