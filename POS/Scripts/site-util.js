var Util = function () {
  var now = Date();
  this._FmtTime = function (nDate) {
    return _pad(nDate.getUTCHours()) + ':' + _pad(nDate.getUTCMinutes()) + ':' + _pad(nDate.getUTCSeconds());
  };


  var _toDateTime = function (sNetDate) {
    var nDate = new Date();
    if (sNetDate instanceof Date && isFinite(sNetDate)) {
      nDate = sNetDate;
    } else if (sNetDate !== null) {
      var r = /\/Date\(([0-9]+)\)\//i
      var matches = sNetDate.match(r);
      if (matches.length === 2) {
        var TimeInSec = parseInt(matches[1]);
        nDate = new Date(TimeInSec);
      }
    }
    //Convert date to UTC
    //nDate.setMinutes(nDate.getMinutes() + nDate.getTimezoneOffset());
    return nDate;
  };


  var _pad = function (Num) {
    if (Num >= 10) return Num;
    return '0' + Num;
  };

  var _toDateString = function (nDate) {
    var data =
      _pad(nDate.getUTCFullYear()) + '-' + _pad(nDate.getUTCMonth() + 1) + '-' + _pad(nDate.getUTCDate()) + " " +
      _pad(nDate.getUTCHours()) + ':' + _pad(nDate.getUTCMinutes()) + ':' + _pad(nDate.getUTCSeconds()) + '.' + nDate.getUTCMilliseconds();

    return data;
  };

  var _toFmtDate = function (nDate) {
    var Months = ['Jan', 'Feb', 'Mar', 'Apr', 'May', 'Jun', 'Jul', 'Aug', 'Sep', 'Oct', 'Nov', 'Dec'];
    var Dt = _toDateTime(nDate);
    var data = Dt.getUTCDate() + '-' + Months[Dt.getUTCMonth()] + '-' + Dt.getUTCFullYear();
    //var data = Dt.getDate() + '-' + Months[Dt.getMonth()] + '-' + Dt.getFullYear();
    return data;
  };

  var _toFmtDateTime = function (nDate) {
    var Dt = _toDateTime(nDate);
    var Months = ['Jan', 'Feb', 'Mar', 'Apr', 'May', 'Jun', 'Jul', 'Aug', 'Sep', 'Oct', 'Nov', 'Dec'];
    var data =
      _pad(Dt.getUTCDate()) + '-' + Months[Dt.getUTCMonth()] + '-' + Dt.getUTCFullYear() + ' ' +
      _pad(Dt.getHours()) + ':' + _pad(Dt.getMinutes()) + ':' + _pad(Dt.getSeconds());
    return data;
  };


  var _toTime = function (time) {
    var sec_num = parseInt(time, 10); // don't forget the second param
    var hours = Math.floor(sec_num / 3600);
    var minutes = Math.floor((sec_num - (hours * 3600)) / 60);
    var seconds = sec_num - (hours * 3600) - (minutes * 60);

    if (hours < 10) { hours = "0" + hours; }
    if (minutes < 10) { minutes = "0" + minutes; }
    if (seconds < 10) { seconds = "0" + seconds; }
    return hours + ':' + minutes + ':' + seconds;
  };


  var rad = function (x) {
    return x * Math.PI / 180;
  };

  var _getDistance = function (p1, p2) {
    var R = 6378137; // Earth’s mean radius in meter
    var dLat = rad(p2.lat - p1.lat);
    var dLong = rad(p2.lng - p1.lng);
    var a = Math.sin(dLat / 2) * Math.sin(dLat / 2) +
      Math.cos(rad(p1.lat)) * Math.cos(rad(p2.lat)) *
      Math.sin(dLong / 2) * Math.sin(dLong / 2);
    var c = 2 * Math.atan2(Math.sqrt(a), Math.sqrt(1 - a));
    var d = R * c;
    return d; // returns the distance in meter
  };

  var _ToPath = function (Coordinates) {
    var Path = [];
    if (Coordinates === '' || Coordinates === 'null') return Path;
    var aLatLng = Coordinates.split(',');
    for (var i = 0; i < aLatLng.length; i++) {
      var Points = aLatLng[i].split(' ');
      Path.push({ lat: parseFloat(Points[0]), lng: parseFloat(Points[1]) });
    }
    return Path;
  };
  return {
    FmtTime: _FmtTime,
    toDateTime: _toDateTime,
    toTime: _toTime,
    FmtDate: _toFmtDate,
    toString: _toDateString,
    getDistance: _getDistance,
    toPath: _ToPath,
    FmtDateTime: _toFmtDateTime
  };
}();