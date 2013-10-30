var app = app || {};

app.vm = (function () {

    function hexFromRGB(r, g, b) {
     
        var hex = [
          r.toString(16),
          g.toString(16),
          b.toString(16)
        ];
        $.each(hex, function (nr, val) {
            if (val.length === 1) {
                hex[nr] = "0" + val;
            }
        });
        return '#' + hex.join("").toUpperCase();
    }

    var upRed = function() {
        var val = red();
        if (val !== 255) {
            red(val + 1);
        } else {
            red(255);
        }
    };

    var downRed = function() {
        var val = red();
        if (val !== 0) {
            red(val - 1);
        } else {
            red(0);
        }
    };

    var red = ko.observable(100);
    var green = ko.observable(100);
    var blue = ko.observable(100);
    var opacity = ko.observable(1);

    var hexColor = ko.computed(function () {
        return hexFromRGB(red(), green(), blue());
    });


    var vm = {
        red: red,
        green: green,
        blue: blue,
        opacity: opacity,
        hexColor: hexColor,
        upRed: upRed,
        downRed: downRed
    };

    return vm;

})();

$(function () {

    var correctNumber = function (num, vmField) {

        if (num > 255) {
            vmField(255);
        } else {
            if (num < 0) {
                vmField(0);
            }
        }
    }
    ;

    ko.applyBindings(app.vm);

  /*  app.vm.red.subscribe(function (newValue, oldValue) {
        if (newValue > 255)
            correctNumber(newValue, app.vm.red);
    });*/

});