ko.bindingHandlers.slider = {
    init: function (element, valueAccessor, allBindings, viewModel, bindingContext) {
        var $element = $(element);
        var value = valueAccessor();
        var options = ko.utils.unwrapObservable(allBindings);

        var refresh = function () {
            var val = $(element).slider("value");
            console.log(val);
            value(val);
        };

        $element.slider({
            orientation: "horizontal",
            max: 256,
            min: -1,
            value: value,
            slide: refresh
        });
    },

    update: function (element, valueAccessor, allBindings, viewModel, bindingContext) {
        var $element = $(element);
        var value = ko.utils.unwrapObservable(valueAccessor());
        var options = ko.utils.unwrapObservable(allBindings);

        $element.slider({
            orientation: "horizontal",
            max: 255,
            min: 0,
            value: value
        });
    }
};