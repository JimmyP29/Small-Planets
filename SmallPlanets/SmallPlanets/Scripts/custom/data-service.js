var dataService = {
    loadPlanet: function (planetName, callback) {
        $.ajax({
            async: false,
            url: domain.path + '/SolarSystem/LoadPlanet?planetName=' + planetName,
            dataType: 'json',
            type: 'POST',
            contentType: 'application/json; charset=utf-8',
            success: function (planet) {
                callback.call(this, planet);
            },
            fail: function () {
                console.log("FAIL - Couldn't retrieve planet data");
            }
        });
    },

    loadLog: function (callback) {
        $.ajax({
            async: false,
            url: domain.path + '/Log/GetCaptainsLog',
            type: 'GET',
            contentType: 'application/json; charset=utf-8',
            success: function (log) {
                callback.call(this, log);
            },
            fail: function () {
                console.log("FAIL - Couldn't retrieve log data");
            }
        });
    },

    clearLog: function (logEntries) {
        logEntries = JSON.stringify({'logEntries': logEntries });
        $.ajax({
            async: false,
            url: domain.path + '/Log/ClearLog',
            data: logEntries,
            dataType: 'json',
            contentType: 'application/json; charset=utf-8',
            type: 'POST',
            success: function (data) {
                console.log("SUCCESS - Log Deleted");
            },
            fail: function () {
                console.log("FAIL - Couldn't delete log data");
            }
        });
    },
    //clearLog: function (logEntries, callback) {
    //    logEntries = JSON.stringify({ 'logEntries': logEntries });
    //    $.ajax({
    //        async: false,
    //        url: domain.path + '/Log/ClearLog',
    //        data: logEntries,
    //        dataType: 'json',
    //        contentType: 'application/json; charset=utf-8',
    //        type: 'POST',
    //        success: function (result) {
    //            callback.call(this, result);
    //        },
    //        fail: function () {
    //            console.log("FAIL - Couldn't delete log data");
    //        }
    //    });
    //},

    //saveVisit: function (log, callback) {
    //    $.ajax({
    //        async: false,
    //        url: domain.path + '/Log/SaveVisit',
    //        data: log,
    //        type: 'POST',
    //        success: function () {
    //            callback.call(this, null);
    //            //console.log("SUCCESS - Visit saved");
    //        },
    //        fail: function () {
    //            console.log("FAIL - Couldn't save log data");
    //        }
    //    });
    //}
    saveVisit: function (log) {
        $.ajax({
            async: false,
            url: domain.path + '/Log/SaveVisit',
            data: log,
            type: 'POST',
            success: function () {
                console.log("SUCCESS - Visit saved");
            },
            fail: function () {
                console.log("FAIL - Couldn't save log data");
            }
        });
    }
};

var domain = {
    path: 'http://' + location.hostname + ':' + location.port
};